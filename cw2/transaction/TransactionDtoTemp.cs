using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.transaction
{
    class TransactionDtoTemp : IEnumerable<TransactionDtoTemp>
    {
        public int Id { get; set; }
        public System.DateTime TransactionDate { get; set; }

        public IEnumerator<TransactionDtoTemp> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
