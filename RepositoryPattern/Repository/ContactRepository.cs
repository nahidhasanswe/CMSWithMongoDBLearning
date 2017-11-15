using RepoPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using RepoPattern.Model;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace RepoPattern.Repository
{
    public class ContactRepository : IContacts
    {
        private readonly dbContext _db;

        public ContactRepository()
        {
            _db = new dbContext();
        }
        public async Task Add(Contacts contact)
        {
            await _db.Contact.InsertOneAsync(contact);
        }

        public async Task<Contacts> GetById(string id)
        {
            return await _db.Contact.Find(x=> x.id == id).FirstOrDefaultAsync();
        }

        public async Task<Contacts> GetByName(string name)
        {
            return await _db.Contact.Find(x => x.Name == name).FirstOrDefaultAsync();
        }

        public async Task<Contacts> GetByNumber(string number)
        {
            return null;
        }

        public async Task<IEnumerable<Contacts>> GetContacts()
        {
            return await _db.Contact.Find(x=> true).ToListAsync();
        }

        public async Task<DeleteResult> Remove(string id)
        {
            return await _db.Contact.DeleteOneAsync(Builders<Contacts>.Filter.Eq("Id", id));
        }

        public async Task<DeleteResult> RemoveAll()
        {
            return await _db.Contact.DeleteManyAsync(new BsonDocument());
        }

        public async Task Update(Contacts contact)
        {
            await _db.Contact.ReplaceOneAsync(x=> x.id == contact.id, contact);
        }
    }
}
