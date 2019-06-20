using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.mongo.Models;
using api.mongo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.mongo.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BookController : BaseMongoController<Book>
    {
        public BookController(BookRepository bookRepository) : base(bookRepository)
        {
        }
    }
}