using api.mongo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.mongo.Services
{
    public class BookRepository : BaseMongoRepository<Book>
    {
        public BookRepository(string mongoDBConnectionString, string dbName, string collectionName = nameof(Book)) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}
