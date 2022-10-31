using ead_3_.models;
using ead_3_.services;using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ead_3_.Controllers
{
    [Route("[Controller]")]
    public class FormHandlerController : Controller
    {
        JsonFileBookService BookService;
    public FormHandlerController(JsonFileBookService bookService)
        {
            this.BookService = bookService;
        }
        [HttpGet]
        public string Get(int id,string name,string image) {
            Book obj = new Book();
            obj.book_id=id;
            obj.book_name=name;
            obj.book_image=image;
            IEnumerable<Book> booksData=BookService.getBooksData();
            List<Book> listOfBooks=booksData.ToList();
            listOfBooks.Add(obj);
           return JsonSerializer.Serialize<List<Book>>(listOfBooks);
        }

    }
}