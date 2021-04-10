using cw2.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            domain.OnDate = dto.OnDate;
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
    }
}
