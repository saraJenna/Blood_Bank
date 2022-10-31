using ead_3_.models;
using ead_3_.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ead_3_.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Book> Books { get; private set; }
        public JsonFileBookService BookService ; //store service instance
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, 
            JsonFileBookService bookservice)
        {
            _logger = logger;
            BookService = bookservice; 
        }

        public void OnGet()
        {
          
        }
    }
}
