using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;
using cw2.common.exception;

namespace cw2.contact
{
    public class ContactDao
    {
        private static ContactDao instance = null;

        private ContactDao()
        {
        }
        public static ContactDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContactDao();
                }
                return instance;
            }
        }

        public Contact save(Contact contact)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    if (contact.Id == 0) //Add new record
                    {
                        db.Entry(contact).State = EntityState.Added;
                        db.Contacts.Add(contact);
                    }
                    else
                    {
                        db.Entry(contact).State = EntityState.Modified;
                    }

                    db.SaveChanges();
                }
            } 
            catch(DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            
            return contact;
        }

        public List<Contact> getAllContacts()
        {
            List<Contact> contactList = new List<Contact>();

            using (Entities db = new Entities())
            {
                if (db.Database.Exists())
                {
                    contactList = db.Contacts.ToList<Contact>();
                } 
                else
                {
                    throw new CW2DatabaseUnavaiableException("Database Unavailable");
                }
            }

            return contactList;
        }

        public void delete(int id)
        {
            using (Entities db = new Entities())
            {
                if (db.Database.Exists())
                {
                    Contact contact = db.Contacts.First(e => e.Id == id);
                    var entry = db.Entry(contact);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Contacts.Attach(contact);
                    }
                    db.Contacts.Remove(contact);
                    db.SaveChanges();
                }
                else
                {
                    throw new CW2DatabaseUnavaiableException("Database Unavailable");
                }
               
            }
        }

        public Contact findById(int id)
        {
            using (Entities db = new Entities())
            {
                if (db.Database.Exists())
                {
                    Contact contact = db.Contacts.Where(t => t.Id == id).FirstOrDefault();

                    return contact;
                }
                else
                {
                    throw new CW2DatabaseUnavaiableException("Database Unavailable");
                }

            }
        }

        public List<Contact> searchTransactionByCriteria(ContactDto dto)
        {
            List<Contact> contactList = new List<Contact>();

            using (Entities db = new Entities())
            {
                if (db.Database.Exists())
                {
                    var query = db.Contacts
                        .Where(cont => ( (dto.ContactName == null || cont.ContactName.Contains(dto.ContactName)) && 
                                         (dto.Type == null || cont.Type.Equals(dto.Type)) ));

                    contactList.AddRange(query.ToList<Contact>());
                }
                else
                {
                    throw new CW2DatabaseUnavaiableException("Database Unavailable");
                }

            }
            return contactList;
        }
    }
}
