using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_CORS_newest
{
    public class Book
    {
        public Book()
        {

        }

        public Book(string author, string name, int status)
        {
            Author = author;
            Name = name;
            Status = (Status)status;
        }

        public int Id { get; set; }

        public string Author { get; set; }

        public string Name { get; set; }

        public Status Status { get; set; }
    }
}
