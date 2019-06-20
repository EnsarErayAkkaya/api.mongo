using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api.mongo.Models
{
    public class Person : MongoBaseModel
    {
        

        [BsonElement("Name")]
        public string Name { get; set; }

        public string Password { get; set; }
        
    }
}
