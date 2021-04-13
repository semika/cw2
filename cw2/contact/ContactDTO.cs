using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.contact
{
    public class ContactDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Type { get; set; }

        public int DbEntityId { get; set; }
    }
}
