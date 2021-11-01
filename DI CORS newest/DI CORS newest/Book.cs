using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_CORS_newest
{
    public class Book
    {
        public Book(int id, string author, string name, int status)
        {
            Id = id;
            Author = author;
            Name = name;
            Status = (Status)status;
        }

        public int Id { get; private set; }

        public string Author { get; }

        public string Name { get; }

        public Status Status { get; set; }
    }
}
