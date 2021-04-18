using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static cw2.Cw2DataSet;

namespace cw2.contact
{
    public class ContactTransformer
    {
        private static ContactTransformer instance = null;

        private ContactTransformer()
        {
        }
        public static ContactTransformer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContactTransformer();
                }
                return instance;
            }
        }

        public Contact dtoToDomain(ContactDto dto, Contact domain)
        {
          
            //domain.Id = dto.Id; No need to set the ID
            domain.ContactName = dto.ContactName;
            domain.Email = dto.Email;
            domain.Tel = dto.Tel;
            domain.Type = dto.Type;
            domain.Address = dto.Address;
           
            return domain;
        }

        public ContactDto domainToDto(Contact domain)
        {
            ContactDto dto = new ContactDto();
            dto.Id = domain.Id;
            dto.ContactName = domain.ContactName;
            dto.Email = domain.Email;
            dto.Tel = domain.Tel;
            dto.Type = domain.Type;
            dto.Address = domain.Address;
            return dto;
        }

        public ContactDto dataSetRowToDto(ContactRow row)
        {
            ContactDto dto = new ContactDto();

            dto.Id = row.Id;
            dto.ContactName = row.ContactName;
            dto.Address = row.Address;
            dto.Type = row.Tel;
            dto.Email = row.Email;
            dto.Type = row.Type;

            return dto;
        }

        public ContactRow dtoToDataSetRow(ContactDto dto, ContactRow row)
        {
            row.ContactName = dto.ContactName;
            row.Address = dto.Address;
            row.Type = dto.Type;
            row.Tel = dto.Tel;
            row.Email = dto.Email;

            return row;
        }

        public ContactDto dataGridRowToDto(DataGridViewRow selectedRow)
        {

            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            string name = Convert.ToString(selectedRow.Cells["ContactName"].Value);
            string address = Convert.ToString(selectedRow.Cells["Address"].Value);
            string type = Convert.ToString(selectedRow.Cells["Type"].Value);
            string tel = Convert.ToString(selectedRow.Cells["Tel"].Value);
            string email = Convert.ToString(selectedRow.Cells["Email"].Value);

            ContactDto dto = new ContactDto();
            dto.Id = id;
            dto.ContactName = name;
            dto.Address = address;
            dto.Type = type;
            dto.Tel = tel;
            dto.Email = email;

            return dto;
        }
    }
}
