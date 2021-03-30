using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.transaction
{
    class TransactionDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Amount { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string Type { get; set; }
        public string Occurence { get; set; }
        public string RecurrenceType { get; set; }
        public Nullable<int> OnDate { get; set; }
        public Nullable<int> OnMonth { get; set; }

    }
}
