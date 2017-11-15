using RepoPattern.Model;
using RepoPattern.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Contact
{
    public class ContactActivity
    {
        private readonly ContactRepository _repo;

        public ContactActivity()
        {
            _repo = new ContactRepository();
        }

        public async Task<IEnumerable<Contacts>> GetAllContacts()
        {
            return await _repo.GetContacts();
        }

        public async Task<Contacts> GetByName(string name)
        {
            return await _repo.GetByName(name);
        }

        public async Task<Contacts> GetById(string id)
        {
            return await _repo.GetById(id);
        }
    }
}
