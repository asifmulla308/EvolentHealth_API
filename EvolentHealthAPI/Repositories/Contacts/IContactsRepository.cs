using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvolentHealthAPI.Models;

namespace EvolentHealthAPI.Repositories
{
    public interface IContactsRepository
    {
        Task<IEnumerable<Contact>> GetContacts();
        Task<IEnumerable<Contact>> GetContactsById(int id);
        Task<bool> CreateContact(Contact contact);
        Task<bool> UpdateContactsById(Contact contact);
        Task<bool> UpdateStatus(int id,string status);
        Task<bool> RemoveContactsById(int id);
    }
}
