using cw2.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cw2.Cw2DataSet;

namespace cw2.contact
{

    class ContactDataSetDao
    {
        private static ContactDataSetDao instance = null;

        private ContactDataSetDao()
        {
        }
        public static ContactDataSetDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContactDataSetDao();
                }
                return instance;
            }
        }


        public List<ContactRow> getAllContacts()
        {
            List<ContactRow> contactList = new List<ContactRow>();

            DataTable contactTable = DataSetProvider.Instance.getDataSet().Tables["Contact"];

            foreach (ContactRow contactRow in contactTable.Rows)
            {
                contactList.Add(contactRow);
            }

            return contactList;
        }

        public ContactRow findById(int id)
        {
            Cw2DataSet dataSet = DataSetProvider.Instance.getDataSet();
            ContactRow contactRow = dataSet.Contact.FindById(id);

            return contactRow;
        }
    }
}
