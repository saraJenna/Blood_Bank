using ead_3_.models;
using ead_3_.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ead_3_.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        JsonFileBookService BookService { get; }
        public BooksController(JsonFileBookService bookService)
        {
            this.BookService = bookService;
        }
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return BookService.getBooksData();
        }
    }
}
