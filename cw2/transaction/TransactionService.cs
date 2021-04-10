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

        public TransactionDto save(TransactionDto dto)
        {
            TransactionDao transactionDao = new TransactionDao();
            TransactionTransformer transformer = new TransactionTransformer();
            Transaction transaction = null;

            if (dto.Id != 0) //Update
            {
                transaction = transactionDao.findById(dto.Id, false);
                if (!transaction.ExpireDate.Equals(dto.ExpireDate))
                {
                    //recreate transaction instances
                    transactionDao.clearTransactionInstances(dto.Id);
                    transformer.dtoToDomain(dto, transaction);
                    transaction.TransactionInstances.Clear();
                    saveTransactionInstance(transaction);
                }
            }
            else //create
            {
                transaction = new Transaction();
                transformer.dtoToDomain(dto, transaction);
                saveTransactionInstance(transaction);
            }

            transaction = transactionDao.save(transaction);

            //save locally
            //saveLocalCopy(transaction)

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
            transactionRow.ExpireDate = transaction.ExpireDate;

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

            DataSetProvider.Instance.writeDataSet();
          
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
                transactionInstance.TransactionId = transaction.Id;
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

        public List<TransactionDto> getAllTransactionsFromDataSet()
        {
            TransactionDataSetDao dataSetDao = new TransactionDataSetDao();
            return dataSetDao.getAllTransactions();
        }

    }
}
