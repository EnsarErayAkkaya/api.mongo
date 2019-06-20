using api.mongo.Models;
using api.mongo.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.mongo.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonController : BaseMongoController<Person>
    {

        public PersonController(PersonRepository personRepository) : base(personRepository)
        {
        }
    }
    
}