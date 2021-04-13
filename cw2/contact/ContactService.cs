using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cw2.common;
using static cw2.Cw2DataSet;

namespace cw2.contact
{
    public class ContactService
    {
        private static ContactService instance = null;

        private ContactService()
        {
        }
        public static ContactService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContactService();
                }
                return instance;
            }
        }

        private CW2Response<ContactDto> saveOnDB(ContactDto dto)
        {
            CW2Response<ContactDto> response = new CW2Response<ContactDto>();

            try
            {
                Contact contact = null;

                if (dto.DbEntityId != 0) //Update
                {
                    contact = ContactDao.Instance.findById(dto.DbEntityId);
                    ContactTransformer.Instance.dtoToDomain(dto, contact);
                }
                else //create
                {
                    contact = new Contact();
                    ContactTransformer.Instance.dtoToDomain(dto, contact);
                    contact.Id = 0;
                }

                contact = ContactDao.Instance.save(contact);

                response.dto = ContactTransformer.Instance.domainToDto(contact);
                response.Status = AppConstant.SUCCESS;
                response.Message = "Contact saved successfully";
            }
            catch (Exception e)
            {
                response.Status = AppConstant.ERROR;
                response.Message = "DB Error : Unable to persist contact entity";
                Console.WriteLine(e.StackTrace);
            }

            return response; ;
        }

        private CW2Response<ContactDto> saveDraft(ContactDto dto)
        {
            CW2Response<ContactDto> response = new CW2Response<ContactDto>();

            try
            {
                Cw2DataSet dataSet = DataSetProvider.Instance.getDataSet();

                ContactRow contactRow = null;

                if (dto.DbEntityId == 0) //Entity not saved to database.
                {
                    if (dto.Id != 0) //Update
                    {
                        contactRow = ContactDataSetDao.Instance.findById(dto.Id);
                        ContactTransformer.Instance.dtoToDataSetRow(dto, contactRow);
                    }
                    else //create
                    {
                        contactRow = dataSet.Contact.NewContactRow();
                        ContactTransformer.Instance.dtoToDataSetRow(dto, contactRow);
                        dataSet.Contact.AddContactRow(contactRow);
                    }
                }
                else
                {
                    //Edit contact from the database. Local copy has been removed
                    //need to create a new local copy.

                    contactRow = dataSet.Contact.NewContactRow();
                    ContactTransformer.Instance.dtoToDataSetRow(dto, contactRow);
                    dataSet.Contact.AddContactRow(contactRow);

                }

                dataSet.AcceptChanges();
                DataSetProvider.Instance.writeDataSet();

                response.dto = ContactTransformer.Instance.dataSetRowToDto(contactRow);
                response.Status = AppConstant.SUCCESS;
                response.Message = "Contact local copy saved successfully";

            }
            catch (Exception e)
            {
                response.Status = AppConstant.ERROR;
                response.Message = "DB Error : Unable to persist contact draft";
                Console.WriteLine(e.StackTrace);
            }

            return response;
        }

        public CW2Response<ContactDto> removeDraft(int id)
        {
            CW2Response<ContactDto> response = new CW2Response<ContactDto>();

            try
            {
                Cw2DataSet dataSet = DataSetProvider.Instance.getDataSet();
                ContactRow contactRow = dataSet.Contact.FindById(id);
                contactRow.Delete();
                dataSet.AcceptChanges();
                DataSetProvider.Instance.writeDataSet();

                response.Status = AppConstant.SUCCESS;
                response.Message = "Contact Draft Remove Successfully";
            }
            catch (Exception e)
            {
                response.Status = AppConstant.ERROR;
                response.Message = "Transaction Draft Remove Failed";
                Console.WriteLine(e.StackTrace);
            }

            return response;
        }

        public CW2Response<ContactDto> save(ContactDto dto)
        {
            CW2Response<ContactDto> validated = validateSave(dto);

            if (validated.Status.Equals(AppConstant.ERROR))
            {
                Console.WriteLine("Validation Error : Saving contact failed");
                return validated;
            }

            //save local copy
            CW2Response<ContactDto> saveDraftResponse = saveDraft(dto);
            if (saveDraftResponse.Status.Equals(AppConstant.ERROR))
            {
                Console.WriteLine("Saving Draft Failed..attepmpting the save on database");
            }

            //save data on DB
            CW2Response<ContactDto> saveToDBResponse = saveOnDB(dto);

            if (saveToDBResponse.Status.Equals(AppConstant.SUCCESS))
            {
                //saving data to database success. 
                //remove the local copy.
                Console.WriteLine("Record saved into the database successfully.");
                CW2Response<ContactDto> removeDraftResponse = removeDraft(saveDraftResponse.dto.Id);
            }

            if (saveDraftResponse.Status.Equals(AppConstant.SUCCESS) && saveToDBResponse.Status.Equals(AppConstant.SUCCESS))
            {
                saveToDBResponse.Message = "Record saved successfully";
                saveToDBResponse.Status = AppConstant.SUCCESS;
            }
            else if (saveDraftResponse.Status.Equals(AppConstant.SUCCESS) && saveToDBResponse.Status.Equals(AppConstant.ERROR))
            {
                saveToDBResponse.Message = "System was unable to connect to the database. Record was saved as a draft";
                saveToDBResponse.Status = AppConstant.SUCCESS;
            }
            else if (saveDraftResponse.Status.Equals(AppConstant.ERROR) && saveToDBResponse.Status.Equals(AppConstant.SUCCESS))
            {
                saveToDBResponse.Message = "Record saved successfully";
                saveToDBResponse.Status = AppConstant.SUCCESS;
            }
            else if (saveDraftResponse.Status.Equals(AppConstant.ERROR) && saveToDBResponse.Status.Equals(AppConstant.ERROR))
            {
                saveToDBResponse.Status = AppConstant.ERROR;
                saveToDBResponse.Message = "Record saved failed";
            }

            return saveToDBResponse;
        }

        private CW2Response<ContactDto> validateSave(ContactDto dto)
        {
            CW2Response<ContactDto> response = new CW2Response<ContactDto>();
            response.Status = AppConstant.SUCCESS;
            return response;
        }


        public List<ContactDto> getAllContacts()
        {
            List<Contact> contactList = ContactDao.Instance.getAllContacts();

            List<ContactDto> contactDtoList = new List<ContactDto>();

            foreach (var contact in contactList)
            {
                contactDtoList.Add(ContactTransformer.Instance.domainToDto(contact));
            }

            return contactDtoList;
        }

        public CW2Response<ContactDto> getAllContactsFromDataSet()
        {
            CW2Response<ContactDto> response = new CW2Response<ContactDto>();
            List<ContactDto> contactDtoList = new List<ContactDto>();

            try
            {
                List<ContactRow> contactRows = ContactDataSetDao.Instance.getAllContacts();

                foreach (var contactRow in contactRows)
                {
                    contactDtoList.Add(ContactTransformer.Instance.dataSetRowToDto(contactRow));
                }
                response.Status = AppConstant.SUCCESS;
            }
            catch (Exception e)
            {
                response.Status = AppConstant.ERROR;
                response.Message = "Internal System Failure";
            }

            response.dataList = contactDtoList;
            return response;
        }

        public void delete(int id)
        {
            ContactDao.Instance.delete(id);
        }
    }
}
