using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cw2.common;
using static cw2.Cw2DataSet;
using cw2.common.exception;

namespace cw2.transaction
{
    public sealed class TransactionService
    {
        private static TransactionService instance = null;

        private TransactionService()
        {
        }
        public static TransactionService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TransactionService();
                }
                return instance;
            }
        }

        private CW2Response<TransactionDto> saveOnDB(TransactionDto dto)
        {
            CW2Response<TransactionDto> response = new CW2Response<TransactionDto>();

            try
            {
                //TransactionDao transactionDao = new TransactionDao();
                //TransactionTransformer transformer = new TransactionTransformer();
                Transaction transaction = null;

                if (dto.DbEntityId != 0) //Update
                {
                    transaction = TransactionDao.Instance.findById(dto.DbEntityId, false);
                    TransactionTransformer.Instance.dtoToDomain(dto, transaction);

                    if (!transaction.ExpireDate.Equals(dto.ExpireDate))
                    {
                        //recreate transaction instances
                        TransactionDao.Instance.clearTransactionInstances(dto.Id);
                        populateTransactionInstances(transaction);
                        //transaction.TransactionInstances.Clear();
                    }
                }
                else //create
                {
                    transaction = new Transaction();
                    TransactionTransformer.Instance.dtoToDomain(dto, transaction);
                    transaction.Id = 0;
                    populateTransactionInstances(transaction);
                }

                transaction = TransactionDao.Instance.save(transaction);

                response.dto = TransactionTransformer.Instance.domainToDto(transaction);
                response.Status = AppConstant.SUCCESS;
                response.Message = "Transaction saved successfully";
            } 
            catch(Exception e)
            {
                response.Status = AppConstant.ERROR;
                response.Message = "DB Error : Unable to persist transaction entity";
                Console.WriteLine(e.StackTrace);
            }
           
            return response; ;
        }

        private CW2Response<TransactionDto>  saveDraft(TransactionDto dto)
        {
            CW2Response<TransactionDto> response = new CW2Response<TransactionDto>();

            try
            {
                //TransactionDataSetDao transactionDataSetDao = new TransactionDataSetDao();
                Cw2DataSet dataSet = DataSetProvider.Instance.getDataSet();

                //TransactionTransformer transformer = new TransactionTransformer();
                TransactionRow transactionRow = null;

                if (dto.DbEntityId == 0) //Entity not saved to database.
                {
                    if (dto.Id != 0) //Update
                    {
                        transactionRow = TransactionDataSetDao.Instance.findById(dto.Id);
                        TransactionTransformer.Instance.dtoToDataSetRow(dto, transactionRow);
                    }
                    else //create
                    {
                        transactionRow = dataSet.Transaction.NewTransactionRow();
                        TransactionTransformer.Instance.dtoToDataSetRow(dto, transactionRow);
                        dataSet.Transaction.AddTransactionRow(transactionRow);
                    }
                }
                else
                {
                    //Edit transaction from the database. Local copy has been removed
                    //need to create a new local copy.

                    transactionRow = dataSet.Transaction.NewTransactionRow();
                    TransactionTransformer.Instance.dtoToDataSetRow(dto, transactionRow);
                    dataSet.Transaction.AddTransactionRow(transactionRow);

                }

                dataSet.AcceptChanges();
                DataSetProvider.Instance.writeDataSet();

                response.dto = TransactionTransformer.Instance.dataSetRowToDto(transactionRow);
                response.Status = AppConstant.SUCCESS;
                response.Message = "Transaction local copy saved successfully";

            }
            catch(Exception e)
            {
                response.Status = AppConstant.ERROR;
                response.Message = "DB Error : Unable to persist transaction draft";
                Console.WriteLine(e.StackTrace);
            }

            return response;
        }

        public CW2Response<TransactionDto> removeDraft(int id)
        {
            CW2Response<TransactionDto> response = new CW2Response<TransactionDto>();

            try
            {
                Cw2DataSet dataSet = DataSetProvider.Instance.getDataSet();
                TransactionRow transactionRow = dataSet.Transaction.FindById(id);
                transactionRow.Delete();
                dataSet.AcceptChanges();
                DataSetProvider.Instance.writeDataSet();

                response.Status = AppConstant.SUCCESS;
                response.Message = "Transaction Draft Remove Successfully";
            }
            catch (Exception e)
            {
                response.Status = AppConstant.ERROR;
                response.Message = "Transaction Draft Remove Failed";
                Console.WriteLine(e.StackTrace);
            }
           
            return response;
        }


        /*
         Saves the data into file system
         */
        public CW2Response<TransactionDto> save(TransactionDto dto)
        {

            //save local copy
            CW2Response<TransactionDto> saveDraftResponse = saveDraft(dto);
            if (saveDraftResponse.Status.Equals(AppConstant.ERROR))
            {
                Console.WriteLine("Saving Draft Failed..attepmpting the save on database");
            }

            //save data on DB
            CW2Response<TransactionDto> saveToDBResponse =  saveOnDB(dto);
            
            if (saveToDBResponse.Status.Equals(AppConstant.SUCCESS))
            {
                //saving data to database success. 
                //remove the local copy.
                Console.WriteLine("Record saved into the database successfully.");
                CW2Response<TransactionDto> removeDraftResponse = removeDraft(saveDraftResponse.dto.Id);
            }

            if (saveDraftResponse.Status.Equals(AppConstant.SUCCESS) && saveToDBResponse.Status.Equals(AppConstant.SUCCESS))
            {
                saveToDBResponse.Message = "Record saved successfully";
                saveToDBResponse.Status = AppConstant.SUCCESS;
            }
            else if (saveDraftResponse.Status.Equals(AppConstant.SUCCESS) && saveToDBResponse.Status.Equals(AppConstant.ERROR))
            {
                saveToDBResponse.Message = "System was unable to connect to the database. Record was saved as a draft";
                saveToDBResponse.Status = AppConstant.SUCCESS;
            }
            else if (saveDraftResponse.Status.Equals(AppConstant.ERROR) && saveToDBResponse.Status.Equals(AppConstant.SUCCESS))
            {
                saveToDBResponse.Message = "Record saved successfully";
                saveToDBResponse.Status = AppConstant.SUCCESS;
            }
            else if (saveDraftResponse.Status.Equals(AppConstant.ERROR) && saveToDBResponse.Status.Equals(AppConstant.ERROR))
            {
                saveToDBResponse.Status = AppConstant.ERROR;
                saveToDBResponse.Message = "Record saved failed";
            }

            return saveToDBResponse;
        }

        private void populateTransactionInstances(Transaction transaction)
        {
            DateTime startDate = transaction.CreatedDate;
            DateTime expireDate = (DateTime)transaction.ExpireDate;

            foreach (DateTime day in CommonUtil.eachDay(startDate, expireDate))
            {
                TransactionInstance transactionInstance = new TransactionInstance();
                transactionInstance.TransactionDate = day;
                transactionInstance.Transaction = transaction;
                transactionInstance.TransactionId = transaction.Id;
                transaction.TransactionInstances.Add(transactionInstance);
            }
        }

        public CW2Response<TransactionDto> getAllTransactions()
        {
            CW2Response<TransactionDto> response = new CW2Response<TransactionDto>();
            
            List<TransactionDto> transactionDtoList = new List<TransactionDto>();

            try
            {
                //TransactionTransformer transformer = new TransactionTransformer();
                //TransactionDao transactionDao = new TransactionDao();
                List<Transaction> transactionList = TransactionDao.Instance.getAllTransactions();
                foreach (var transaction in transactionList)
                {
                    transactionDtoList.Add(TransactionTransformer.Instance.domainToDto(transaction));
                }
               
                response.Status = AppConstant.SUCCESS;
            }
            catch(CW2DatabaseUnavaiableException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Database not available..");
                response.Status = AppConstant.ERROR; //workin offline mode
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                response.Status = AppConstant.ERROR;
            }

            response.dataList = transactionDtoList;
            return response;
        }

        public CW2Response<TransactionDto> searchTransactionByCriteria(TransactionDto dto)
        {
            CW2Response<TransactionDto> response = new CW2Response<TransactionDto>();

            List<TransactionDto> transactionDtoList = new List<TransactionDto>();

            try
            {
                List<Transaction> transactionList = TransactionDao.Instance.searchTransactionByCriteria(dto);

                foreach (var transaction in transactionList)
                {
                    transactionDtoList.Add(TransactionTransformer.Instance.domainToDto(transaction));
                }
                
                response.Status = AppConstant.SUCCESS;
            }
            catch (CW2DatabaseUnavaiableException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Database not available..");
                response.Status = AppConstant.ERROR; //workin offline mode
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                response.Status = AppConstant.ERROR;
            }

            response.dataList = transactionDtoList;

            return response;
        }

        public CW2Response<TransactionDto> getAllTransactionsFromDataSet()
        {
            CW2Response<TransactionDto> response = new CW2Response<TransactionDto>();
            List<TransactionDto> transactionDtoList = new List<TransactionDto>();

            try
            {
                //TransactionTransformer transformer = new TransactionTransformer();
                //TransactionDataSetDao dataSetDao = new TransactionDataSetDao();
                List<TransactionRow> transactionRows = TransactionDataSetDao.Instance.getAllTransactions();

                foreach (var transactionRow in transactionRows)
                {
                    transactionDtoList.Add(TransactionTransformer.Instance.dataSetRowToDto(transactionRow));
                }
                response.Status = AppConstant.SUCCESS;
            }
            catch (Exception e)
            {
                response.Status = AppConstant.ERROR;
                response.Message = "Internal System Failure";
            }

            response.dataList = transactionDtoList;
            return response;
        }

    }
}
