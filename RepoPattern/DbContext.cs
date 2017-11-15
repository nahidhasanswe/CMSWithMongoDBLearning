using System;
using MongoDB.Driver;
using System.Configuration;
using RepoPattern.Model;

namespace RepoPattern
{
    public class dbContext
    {
        public IMongoDatabase _db { get; }

        public dbContext()
        {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings.Get("connectionString"));
            _db = client.GetDatabase(ConfigurationManager.AppSettings.Get("Database"));
        }

        public IMongoCollection<Contacts> Contact
        {
            get
            {
               return _db.GetCollection<Contacts>("Contacts");
            }
        }
    }
}
