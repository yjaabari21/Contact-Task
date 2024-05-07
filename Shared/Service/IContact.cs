using ContactListTask.Server.Models;

namespace ContactListTask.Server.Service
{
    public interface IContact
    {
        public List<ContactList> GetAllContacts(int id);
        public List<ContactList> AddContact(ContactList contact);

        public List<ContactList> GetByIdAsync(int id);

        public List<ContactList> UpdateAsync(ContactList contact);

        public bool RemoveContact(int id);
    }
}