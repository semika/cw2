using cw2.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static cw2.Cw2DataSet;

namespace cw2.transaction
{
    class TransactionTransformer
    {
        private static TransactionTransformer instance = null;

        private TransactionTransformer()
        {
        }
        public static TransactionTransformer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TransactionTransformer();
                }
                return instance;
            }
        }

        public TransactionDto domainToDto(Transaction domain)
        {
            TransactionDto dto = new TransactionDto();

            dto.Id = domain.Id;
            dto.Occurence = domain.Occurence;
            dto.OnDate = domain.OnDate;
            dto.ExpireDate = (DateTime)domain.ExpireDate; 
            dto.OnMonth = domain.OnMonth;
            dto.RecurrenceType = domain.RecurrenceType;
            dto.Title = domain.Title;
            dto.Type = domain.Type;
            dto.Amount = domain.Amount;
            dto.CreatedDate = domain.CreatedDate;
            dto.ExpireDate = (DateTime)domain.ExpireDate;
            dto.DbEntityId = domain.Id;

            return dto;
        }

        public Transaction dtoToDomain(TransactionDto dto, Transaction domain)
        {
           // domain.Id = dto.Id; No need to set the ID
            domain.Occurence = dto.Occurence;
            if (dto.OnDate != null)
            {
                domain.OnDate = (int)dto.OnDate;
            } 
            else
            {
                domain.OnDate = null;
            }
           
            domain.ExpireDate = dto.ExpireDate;
            domain.OnMonth = dto.OnMonth;  
            domain.RecurrenceType = dto.RecurrenceType;
            domain.Title = dto.Title;
            domain.Type = dto.Type;
            domain.Amount = dto.Amount;
            domain.CreatedDate = dto.CreatedDate;
            domain.ExpireDate = domain.ExpireDate;

            return domain;
        }

        public TransactionDto dataSetRowToDto(TransactionRow row)
        {
            TransactionDto dto = new TransactionDto();

            dto.Id = row.Id;
            dto.Title = row.Title;
            dto.Amount = row.Amount;
            dto.Type = row.Type;
            dto.CreatedDate = row.Date;
            dto.Occurence = row.Occuerence;
            
            if (row.RecurrenceType != null)
            {
                dto.RecurrenceType = row.RecurrenceType;
            }
            
            dto.OnDate = row.OnDate;
            dto.OnMonth = row.OnMonth;
            dto.ExpireDate = row.ExpireDate;

            return dto;
        }

        public TransactionRow dtoToDataSetRow(TransactionDto dto, TransactionRow row)
        {
            row.Amount = dto.Amount;
            row.Title = dto.Title;
            row.Type = dto.Type;
            row.Date = dto.CreatedDate;
            row.Occuerence = dto.Occurence;
            row.RecurrenceType = dto.RecurrenceType;

            if (dto.OnDate != null)
            {
                row.OnDate = (int)dto.OnDate;
            }

            row.OnMonth = dto.OnMonth;
            row.ExpireDate = dto.ExpireDate;

            return row;
        }

        public TransactionDto dataGridRowToDto(DataGridViewRow selectedRow)
        {

            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            String title = Convert.ToString(selectedRow.Cells["Title"].Value);
            double amount = Convert.ToDouble(selectedRow.Cells["Amount"].Value);
            DateTime date = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
            DateTime expireDate = Convert.ToDateTime(selectedRow.Cells["ExpireDate"].Value);
            String type = Convert.ToString(selectedRow.Cells["Type"].Value);
            String occurence = Convert.ToString(selectedRow.Cells["Occurence"].Value);
            String recurrenceType = Convert.ToString(selectedRow.Cells["RecurrenceType"].Value);
            int onDate = Convert.ToInt32(selectedRow.Cells["OnDate"].Value);
            String onMonth = Convert.ToString(selectedRow.Cells["OnMonth"].Value);

            TransactionDto dto = new TransactionDto();
            dto.Id = id;
            dto.Title = title;
            dto.Amount = amount;
            dto.CreatedDate = date;
            dto.ExpireDate = expireDate;
            dto.Type = type;
            dto.Occurence = occurence;
            dto.RecurrenceType = recurrenceType;
            dto.OnDate = onDate;
            dto.OnMonth = onMonth;

            return dto;
        }
    }
}
