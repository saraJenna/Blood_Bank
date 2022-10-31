using ead_3_.models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ead_3_.services
{
    public class JsonFileBookService
    {
        public JsonFileBookService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        public string JsonFilePath { get 
            {
                return Path.Combine(WebHostEnvironment.WebRootPath,"data","books.json"); 
            } 
        }
        public IEnumerable<Book> getBooksData()
        {  //brings book data in program file from path given here
       using(var json_file=File.OpenText(JsonFilePath))
            {
             return   JsonSerializer.Deserialize<Book[]>(json_file.ReadToEnd());
            }
        }     
        
            }
}
