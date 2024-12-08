using ContactsManagementAPI.Models;
using ContactsManagementAPI.Models.DTO;
using ContactsManagementAPI.Repositories.Interface;
using ContactsManagementAPI.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ContactsManagementAPI.Repositories.Implementation
{
    public class ContactRepository : IContactRepository
    {
        
        public bool CreateContact(ContactDTO contactDTO)
        {
            bool created = false;
            try
            {   
                Contact contact = new Contact();
                var lstContact = Util.ReadFromFile();
                contact.Id = lstContact.Count > 0 ? lstContact.Max(c => c.Id) + 1 : 1;
                contact.Firstname = contactDTO.FirstName;
                contact.Lastname = contactDTO.LastName;
                contact.Email = contactDTO.Email;
                lstContact.Add(contact);
                created = Util.WriteFromFile(lstContact);
            }
            catch (Exception ex)
            {

                created = false;
            }
            return created;
        }

        public bool DeleteContact( int id)
        {
            List<Contact> contacts = Util.ReadFromFile();

            var contact = contacts.FirstOrDefault(p => p.Id == id);
            if (contact == null)
            {
                return false;
            }
            contacts.Remove(contact);
            Util.WriteFromFile(contacts);
            return true;
        }


        public List<Contact> GetAll()
        {
            var contacts = Util.ReadFromFile();
            return contacts;
        }

        public bool UpdateContact(ContactDTO updateContact, int id)
        {
            List<Contact> contacts = Util.ReadFromFile();

            var contact = contacts.FirstOrDefault(p => p.Id == id);
            if (contact == null)
            {
                return false;
            }
            contact.Firstname = updateContact.FirstName;
            contact.Lastname = updateContact.LastName;
            contact.Email = updateContact.Email;
            Util.WriteFromFile(contacts);
            return true;
        }

        public bool UpdateContact(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
