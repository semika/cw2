using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.contact
{
    public class ContactTransformer
    {
        public Contact dtoToDomain(ContactDto dto)
        {
            Contact contact = new Contact();
          
            contact.Id = dto.Id;
            contact.Name = dto.Name;
            contact.Email = dto.Email;
            contact.Tel = dto.Tel;
            contact.Type = dto.Type;
            contact.Address = dto.Address;
           
            return contact;
        }

        public ContactDto domainToDto(Contact domain)
        {
            ContactDto dto = new ContactDto();
            dto.Id = domain.Id;
            dto.Name = domain.Name;
            dto.Email = domain.Email;
            dto.Tel = domain.Tel;
            dto.Type = domain.Type;
            dto.Address = domain.Address;
            return dto;
        }
    }
}
