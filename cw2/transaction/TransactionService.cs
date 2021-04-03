using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cw2.common;

namespace cw2.transaction
{
    class TransactionService
    {

        public TransactionDto save(TransactionDto transactionDto)
        {
            TransactionDao transactionDao = new TransactionDao();
            TransactionTransformer transformer = new TransactionTransformer();
            Transaction transaction = transformer.dtoToDomain(transactionDto);

            saveTransactionInstance(transaction);

            //save locally
            saveLocalCopy(transaction);

            transaction = transactionDao.save(transaction);

            return transformer.domainToDto(transaction);
        }

        private void saveLocalCopy(Transaction transaction)
        {
            Cw2DataSet dataSet = DataSetProvider.Instance.getDataSet();

            Cw2DataSet.TransactionRow transactionRow = dataSet.Transaction.NewTransactionRow();
            transactionRow.Amount = transaction.Amount;
            transactionRow.Title = transaction.Title;
            transactionRow.Type = transaction.Type;
            transactionRow.Date = transaction.Date;
            transactionRow.Occuerence = transaction.Occurence;
            transactionRow.RecurrenceType = transaction.RecurrenceType;
            transactionRow.OnDate = transaction.OnDate;
            transactionRow.OnMonth = transaction.OnMonth;


            dataSet.Transaction.AddTransactionRow(transactionRow);

            //Add transaction instances
            foreach (TransactionInstance transactionInstance in transaction.TransactionInstances)
            {
                Cw2DataSet.TransactionInstanceRow transactionInstanceRow = dataSet.TransactionInstance.NewTransactionInstanceRow();
                transactionInstanceRow.Date = transactionInstance.Date;
                transactionInstanceRow.TransactionRow = transactionRow;
                dataSet.TransactionInstance.AddTransactionInstanceRow(transactionInstanceRow);
            }

            dataSet.AcceptChanges();
            dataSet.WriteXml(@"C:\Users\semika\Cw2DataSet.xml");
        }

        private void saveTransactionInstance(Transaction transaction)
        {
            DateTime startDate = transaction.Date;
            DateTime expireDate = (DateTime)transaction.ExpireDate;

            foreach (DateTime day in CommonUtil.eachDay(startDate, expireDate))
            {
                TransactionInstance transactionInstance = new TransactionInstance();
                transactionInstance.Date = day;
                transactionInstance.Transaction = transaction;
                transaction.TransactionInstances.Add(transactionInstance);
            }
        }

        public List<TransactionDto> getAllTransactions()
        {
            TransactionTransformer transformer = new TransactionTransformer();
            TransactionDao transactionDao = new TransactionDao();
            List<Transaction> transactionList = transactionDao.getAllTransactions();

            List<TransactionDto> transactionDtoList = new List<TransactionDto>();

            foreach (var transaction in transactionList)
            {
                transactionDtoList.Add(transformer.domainToDto(transaction));
            }

            return transactionDtoList;
        }

    }
}
