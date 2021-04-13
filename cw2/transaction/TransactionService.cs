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
                Transaction transaction = null;

                if (dto.DbEntityId != 0) //Update
                {
                    transaction = TransactionDao.Instance.findById(dto.DbEntityId, false);
                    TransactionTransformer.Instance.dtoToDomain(dto, transaction);

                    if (!transaction.ExpireDate.Equals(dto.ExpireDate))
                    {
                        //recreate transaction instances
                        TransactionDao.Instance.clearTransactionInstances(dto.Id);
                        populateTransactionInstances(transaction, dto);
                        //transaction.TransactionInstances.Clear();
                    }
                }
                else //create
                {
                    transaction = new Transaction();
                    TransactionTransformer.Instance.dtoToDomain(dto, transaction);
                    transaction.Id = 0;
                    populateTransactionInstances(transaction, dto);
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
                Cw2DataSet dataSet = DataSetProvider.Instance.getDataSet();

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
            CW2Response<TransactionDto> validated = validateSave(dto);
            if (validated.Status.Equals(AppConstant.ERROR))
            {
                Console.WriteLine("Validation Error : Saving transaction failed");
                return validated;
            }

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

        private List<DateTime> getTransactionInstanceDates(TransactionDto dto)
        {
            List<DateTime> dateTimeList = new List<DateTime>();

            string recurrentType = dto.RecurrenceType;

            switch (recurrentType)
            {
                case "none":

                    break;
                case "Daily":
                    
                    DateTime dailyDate = dto.CreatedDate;

                    while(dailyDate <= dto.ExpireDate)
                    {
                        dateTimeList.Add(dailyDate);
                        dailyDate = dailyDate.AddDays(1);
                    }
                   
                    break;
                case "Weekly":

                    DateTime weeklyDate = dto.CreatedDate;

                    while (weeklyDate <= dto.ExpireDate)
                    {
                        dateTimeList.Add(weeklyDate);
                        weeklyDate = weeklyDate.AddDays(7);
                    }

                    break;
                case "Monthly":

                    DateTime monthlyDate = dto.CreatedDate;

                    while (monthlyDate <= dto.ExpireDate)
                    {
                        dateTimeList.Add(monthlyDate);
                        monthlyDate = monthlyDate.AddMonths(1);
                    }
                    break;

                case "Yearly":
                    DateTime yearlyDate = dto.CreatedDate;

                    while (yearlyDate <= dto.ExpireDate)
                    {
                        dateTimeList.Add(yearlyDate);
                        yearlyDate = yearlyDate.AddYears(1);
                    }
                    break;
            }

            return dateTimeList;
        }

        private CW2Response<TransactionDto> validateSave(TransactionDto dto)
        {
            CW2Response<TransactionDto> response = new CW2Response<TransactionDto>();

            try
            {
                validateDateRange(dto);
                response.Status = AppConstant.SUCCESS;
            }
            catch(CW2DataValidationException e)
            {
                response.Status = AppConstant.ERROR;
                response.Message = e.Message;
                Console.WriteLine(e.Message);
            }

            return response;
        }

        private void validateDateRange(TransactionDto dto)
        {

            string recurrentType = dto.RecurrenceType;

            switch (recurrentType)
            {
                case "none":
                       
                    break;
                case "Daily":
                    if (dto.ExpireDate <= dto.CreatedDate)
                    {
                        throw new CW2DataValidationException("The expire date can not be same or earlier than the created date");
                    }
                    break;
                case "Weekly":
                    DateTime nextWeekDay = dto.CreatedDate.AddDays(7);
                    if (dto.ExpireDate.Date < nextWeekDay.Date)
                    {
                        throw new CW2DataValidationException("Invalid date range for weekly recurring transaction");
                    }
                    break;
                case "Monthly":
                    DateTime nextMonthDay = dto.CreatedDate.AddMonths(1);
                    if (dto.ExpireDate.Date < nextMonthDay.Date)
                    {
                        throw new CW2DataValidationException("Invalid date range for monthly recurring transaction");
                    }
                    break;
                case "Yearly":
                    DateTime nextYearDay = dto.CreatedDate.AddYears(1);
                    if (dto.ExpireDate.Date < nextYearDay.Date)
                    {
                        throw new CW2DataValidationException("Invalid date range for yearly recurring transaction");
                    }
                    break;
                    break;
            }
            
        }

        private void populateTransactionInstances(Transaction transaction, TransactionDto dto)
        {
            DateTime startDate = transaction.CreatedDate;
            DateTime expireDate = (DateTime)transaction.ExpireDate;


            List<DateTime> instanceDateList = getTransactionInstanceDates(dto);

            foreach (DateTime day in instanceDateList)
            {
                TransactionInstance transactionInstance = new TransactionInstance();
                transactionInstance.TransactionDate = day;
                transactionInstance.Transaction = transaction;
                transactionInstance.TransactionId = transaction.Id;
                transaction.TransactionInstances.Add(transactionInstance);
            }

           /* foreach (DateTime day in CommonUtil.eachDay(startDate, expireDate))
            {
                TransactionInstance transactionInstance = new TransactionInstance();
                transactionInstance.TransactionDate = day;
                transactionInstance.Transaction = transaction;
                transactionInstance.TransactionId = transaction.Id;
                transaction.TransactionInstances.Add(transactionInstance);
            }*/
        }

        public CW2Response<TransactionDto> getAllTransactions()
        {
            CW2Response<TransactionDto> response = new CW2Response<TransactionDto>();
            
            List<TransactionDto> transactionDtoList = new List<TransactionDto>();

            try
            {
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
