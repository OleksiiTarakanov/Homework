using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_CORS_newest
{
    public class BookService : IBookService
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            { 
            new Book(1, "Gogol", "dead souls", 0),
            new Book(2, "LALA", "LALALALALA", 0)
            };
        }
    }
}
