using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.transaction
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Amount { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ExpireDate { get; set; }
        public string Type { get; set; }
        public string Occurence { get; set; }
        public string RecurrenceType { get; set; }
        public Nullable<int> OnDate { get; set; }
        public string OnMonth { get; set; }

        public int DbEntityId { get; set; }

    }
}
