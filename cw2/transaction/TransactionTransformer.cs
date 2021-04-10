using cw2.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cw2.Cw2DataSet;

namespace cw2.transaction
{
    class TransactionTransformer
    {
        public TransactionDto domainToDto(Transaction domain)
        {
            TransactionDto dto = new TransactionDto();

            dto.Id = domain.Id;
            dto.Occurence = domain.Occurence;
            dto.OnDate = domain.OnDate;
            dto.ExpireDate = domain.ExpireDate; 
            dto.OnMonth = domain.OnMonth;
            dto.RecurrenceType = domain.RecurrenceType;
            dto.Title = domain.Title;
            dto.Type = domain.Type;
            dto.Amount = domain.Amount;
            dto.Date = domain.Date;
            dto.ExpireDate = domain.ExpireDate;

            return dto;
        }

        public Transaction dtoToDomain(TransactionDto dto, Transaction domain)
        {
            domain.Id = dto.Id;
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
            domain.Date = dto.Date;
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
            dto.Date = row.Date;
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
            row.Date = dto.Date;
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
    }
}
