using System.Xml;
using ContactListTask.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactListTask.Server.Service
{
    public class ContactService : IContact
    {
        private readonly ContactTaskContext? _context;
        public ContactService(ContactTaskContext? context)
        {
            _context = context;
        }
        public async Task AddContact(ContactList entity)
        {
            try
            {

                _context.ContactLists.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch 
            {
                throw new Exception();
            }
        }
        public async Task<List<ContactList>> GetByIdAsync()
        {
            try
            {
                return await _context.ContactLists.ToListAsync();
            }
            catch 
            {
                throw new Exception();
            }
            
        }
        public async Task<ContactList> GetByIdAsync(int id)
        {
            try
            {
                return await _context.ContactLists.FindAsync(id);
            }
            catch
            {
                throw new Exception();
            }
        }
        public async Task UpdateAsync(ContactList entity)
        {
            try {  
                _context.ContactLists.Update(entity);
                await _context.SaveChangesAsync();
            }
            catch {
                throw new Exception();
            }
           
        }
        public async Task DeleteAsync(int id)
        {
            try
            {
                var entity = await _context.ContactLists.FindAsync(id);
                if (entity != null)
                {
                _context.ContactLists.Remove(entity);
                await _context.SaveChangesAsync();
                }
                else
                {
                    throw new ArgumentNullException(nameof(entity));
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        public List<ContactList> GetContacts()
        {
            throw new NotImplementedException();
        }

        public List<ContactList> GetAllContacts()
        {
            throw new NotImplementedException();
        }

        List<ContactList> IContact.AddContact(ContactList contact)
        {
            throw new NotImplementedException();
        }

        public bool RemoveContact(int id)
        {
            throw new NotImplementedException();
        }

        List<ContactList> IContact.UpdateAsync(ContactList contact)
        {
            throw new NotImplementedException();
        }

        public List<ContactList> GetAllContacts(int id)
        {
            throw new NotImplementedException();
        }

        List<ContactList> IContact.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
