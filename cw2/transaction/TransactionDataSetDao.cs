using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cw2.common;
using System.Data.SqlClient;
using System.Data;

namespace cw2.transaction
{
    class TransactionDataSetDao
    {
        public List<TransactionDto> getAllTransactions()
        {
            List<TransactionDto> transactionList = new List<TransactionDto>();

            DataTable transactionTable = DataSetProvider.Instance.getDataSet().Tables["Transaction"];

            foreach(DataRow row in transactionTable.Rows)
            {
                TransactionDto dto = new TransactionDto();

                dto.Id = Convert.ToInt32(row["Id"]);
                dto.Title = Convert.ToString(row["Title"]);
                dto.Amount = Convert.ToDouble(row["Amount"]);
                dto.Date = Convert.ToDateTime(row["Date"]);
                dto.Type = Convert.ToString(row["Type"]);
                dto.Occurence = Convert.ToString(row["Occuerence"]);
                dto.RecurrenceType = Convert.ToString(row["RecurrenceType"]);
                dto.OnDate = Convert.ToInt32(row["OnDate"]);
                dto.OnMonth = Convert.ToString(row["OnMonth"]);
                dto.ExpireDate = Convert.ToDateTime(row["ExpireDate"]); 
                
                transactionList.Add(dto);
                
            }
            
            return transactionList;
        }
    }
}
