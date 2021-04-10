using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cw2.common;
using static cw2.Cw2DataSet;

namespace cw2.transaction
{
    class TransactionService
    {

        public TransactionDto saveOnDB(TransactionDto dto)
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
                    //transaction.TransactionInstances.Clear();
                }
            }
            else //create
            {
                transaction = new Transaction();
            }

            transformer.dtoToDomain(dto, transaction);
            saveTransactionInstance(transaction);

            transaction = transactionDao.save(transaction);

            return transformer.domainToDto(transaction);
        }

        public TransactionDto save(TransactionDto dto)
        {
            TransactionDataSetDao transactionDataSetDao = new TransactionDataSetDao();
            Cw2DataSet dataSet = DataSetProvider.Instance.getDataSet();

            TransactionTransformer transformer = new TransactionTransformer();
            TransactionRow transactionRow = null; 

            if (dto.Id != 0) //Update
            {
                transactionRow = transactionDataSetDao.findById(dto.Id);
                transformer.dtoToDataSetRow(dto, transactionRow);
            }
            else //create
            {
                transactionRow = dataSet.Transaction.NewTransactionRow();
                transformer.dtoToDataSetRow(dto, transactionRow);
                dataSet.Transaction.AddTransactionRow(transactionRow);
            }

            dataSet.AcceptChanges();
            DataSetProvider.Instance.writeDataSet();

            //save data on DB
            saveOnDB(dto);

            return transformer.dataSetRowToDto(transactionRow);
        }

        private void saveLocalCopy(TransactionDto dto)
        {
            Cw2DataSet dataSet = DataSetProvider.Instance.getDataSet();

            Cw2DataSet.TransactionRow transactionRow = dataSet.Transaction.NewTransactionRow();
            transactionRow.Amount = dto.Amount;
            transactionRow.Title = dto.Title;
            transactionRow.Type = dto.Type;
            transactionRow.Date = dto.Date;
            transactionRow.Occuerence = dto.Occurence;
            transactionRow.RecurrenceType = dto.RecurrenceType;
            transactionRow.OnDate = (int)dto.OnDate;
            transactionRow.OnMonth = dto.OnMonth;
            transactionRow.ExpireDate = dto.ExpireDate;

            dataSet.Transaction.AddTransactionRow(transactionRow);

            //Add transaction instances
            /*foreach (TransactionInstance transactionInstance in transaction.TransactionInstances)
            {
                Cw2DataSet.TransactionInstanceRow transactionInstanceRow = dataSet.TransactionInstance.NewTransactionInstanceRow();
                transactionInstanceRow.Date = transactionInstance.Date;
                transactionInstanceRow.TransactionRow = transactionRow;
                dataSet.TransactionInstance.AddTransactionInstanceRow(transactionInstanceRow);
            }*/

            dataSet.AcceptChanges();

            DataSetProvider.Instance.writeDataSet();
          
        }

        private void updateLocalCopy(TransactionDto dto)
        {
            Cw2DataSet dataSet = DataSetProvider.Instance.getDataSet();
            var x = dataSet.Transaction.FindById(dto.Id);
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
            TransactionTransformer transformer = new TransactionTransformer();
            TransactionDataSetDao dataSetDao = new TransactionDataSetDao();
            List<TransactionRow> transactionRows = dataSetDao.getAllTransactions();

            List<TransactionDto> transactionDtoList = new List<TransactionDto>();

            foreach (var transactionRow in transactionRows)
            {
                transactionDtoList.Add(transformer.dataSetRowToDto(transactionRow));
            }

            return transactionDtoList;

        }

    }
}
