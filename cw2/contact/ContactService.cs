using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.contact
{
    public class ContactService
    {
        
        public ContactDto save(ContactDto contactDto)
        {
            ContactDao contactDao = new ContactDao();
            ContactTransformer transformer = new ContactTransformer();
            Contact contact = transformer.dtoToDomain(contactDto);
            contactDao.save(contact);

            return transformer.domainToDto(contact);
        }


        public List<ContactDto> getAllContacts()
        {
            ContactTransformer transformer = new ContactTransformer();
            ContactDao contactDao = new ContactDao();
            List<Contact> contactList = contactDao.getAllContacts();

            List<ContactDto> contactDtoList = new List<ContactDto>();

            foreach (var contact in contactList)
            {
                contactDtoList.Add(transformer.domainToDto(contact));
            }

            return contactDtoList;
        }

        public void delete(int id)
        {
            ContactDao contactDao = new ContactDao();
            contactDao.delete(id);
        }
    }
}
