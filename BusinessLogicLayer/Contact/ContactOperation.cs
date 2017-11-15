using RepoPattern.Model;
using RepoPattern.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Contact
{
    public class ContactOperation
    {
        private readonly ContactRepository _repo = new ContactRepository();

        public ContactOperation()
        {
            _repo = new ContactRepository();
        }

        public async Task AddContact(Contacts contact)
        {
            await _repo.Add(contact);
        }

        public async Task UpdateContact(Contacts contact)
        {
            await _repo.Update(contact);
        }

        public async Task RemoveContact(string id)
        {
            await _repo.Remove(id);
        }

        public async Task RemoveAll()
        {
            await _repo.RemoveAll();
        }
    }
}
