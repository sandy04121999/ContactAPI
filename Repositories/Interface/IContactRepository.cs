using ContactsManagementAPI.Models;
using ContactsManagementAPI.Models.DTO;
using System.ComponentModel;

namespace ContactsManagementAPI.Repositories.Interface
{
    public interface IContactRepository
    {
        bool CreateContact(ContactDTO contact);

        List<Contact> GetAll();

        bool UpdateContact(ContactDTO contact, int id);

        bool DeleteContact(int id);
    }
}
