using api.mongo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.mongo.Services
{
    public class PersonRepository : BaseMongoRepository<Person>
    {
        public PersonRepository(string mongoDBConnectionString, string dbName, string collectionName = nameof(Person)) : base(mongoDBConnectionString, dbName, collectionName )
        {
        }
    }
}
