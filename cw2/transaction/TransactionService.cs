using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.transaction
{
    class TransactionService
    {

        public TransactionDto save(TransactionDto transactionDto)
        {
            TransactionDao transactionDao = new TransactionDao();
            TransactionTransformer transformer = new TransactionTransformer();
            Transaction transaction = transformer.dtoToDomain(transactionDto); 
            transactionDao.save(transaction);

            return transformer.domainToDto(transaction);
        }

    }
}
