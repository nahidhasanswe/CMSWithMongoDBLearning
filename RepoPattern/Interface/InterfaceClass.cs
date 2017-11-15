using MongoDB.Driver;
using RepoPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepoPattern.Interface
{
    public interface IContacts
    {
        Task<IEnumerable<Contacts>> GetContacts();
        Task<Contacts> GetByName(string name);
        Task<Contacts> GetByNumber(string number);
        Task<Contacts> GetById(string id);
        Task Add(Contacts contact);
        Task Update(Contacts contact);
        Task<DeleteResult> Remove(string id);
        Task<DeleteResult> RemoveAll();

    }
}
