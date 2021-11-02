using DI_CORS_newest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_CORS_newest
{
    public interface IBookService
    {
        public Task<List<Book>> GetBooks();
        public Task UpdateBookStatus(int id);

    }
}
