using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ead_3_.models;
using ead_3_.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ead_3_.Pages
{
   
    public class BookListModel : PageModel
    {
         JsonFileBookService BookService;
       public IEnumerable<Book> Books;
        public BookListModel(JsonFileBookService bookService) {
            this.BookService = bookService;
        }
        public void OnGet()
        {
            Books = BookService.getBooksData();
        }
    }
}
