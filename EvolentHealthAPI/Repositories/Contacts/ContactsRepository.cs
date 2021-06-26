using EvolentHealthAPI.AutoMapper;
using EvolentHealthAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvolentHealthAPI.Repositories.Contacts
{
    public class ContactsRepository : IContactsRepository
    {
        evolenthealthContext _context;

        public ContactsRepository(evolenthealthContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateContact(Contact contact)
        {
            try
            {
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return false;
            }
        }

        public async Task<IEnumerable<Contact>> GetContacts()
        {
            try
            {
                return await _context.Contacts.ToListAsync();

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return null;
            }
        }

        public async Task<IEnumerable<Contact>> GetContactsById(int id)
        {
            try
            {
                return await _context.Contacts.Where(c => c.Id == id).ToListAsync();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return null;
            }
        }
        public async Task<bool> RemoveContactsById(int id)
        {
            try
            {
                var data = await _context.Contacts.Where(c => c.Id == id).FirstOrDefaultAsync();
                _context.Remove(data);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return false;
            }
        }

        public async Task<bool> UpdateContactsById(Contact contact)
        {
            try
            {
                var existingContact = await _context.Contacts.Where(c => c.Id == contact.Id).FirstOrDefaultAsync();
                if (existingContact != null)
                {
                    existingContact.Firstname = contact.Firstname;
                    existingContact.Lastname = contact.Lastname;
                    existingContact.Email = contact.Email;
                    existingContact.Phonenumber = contact.Phonenumber;
                    existingContact.Status = contact.Status;
                    _context.Entry(existingContact).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return true;
                }

                await _context.SaveChangesAsync();

                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<bool> UpdateStatus(int id, string status)
        {
            try
            {
                var existingContact = await _context.Contacts.Where(c => c.Id == id).FirstOrDefaultAsync();
                if (existingContact != null)
                {
                    existingContact.Status = status == "Active" ? true : false;
                    _context.Entry(existingContact).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return true;
                }

                await _context.SaveChangesAsync();

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
