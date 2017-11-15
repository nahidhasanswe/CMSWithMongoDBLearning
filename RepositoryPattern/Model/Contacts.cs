﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoPattern.Model
{
    public class Contacts
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }

    public class PhoneNumber
    {
        public string TypeName { get; set; }
        public string Number { get; set; }
    }
}
