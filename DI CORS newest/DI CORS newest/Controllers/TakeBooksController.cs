using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_CORS_newest.Controllers
{
    [Route("TakeBook")]
    [ApiController]
    public class TakeBooksController : ControllerBase
    {
        private readonly IBookService _bookService;


        public TakeBooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public List<Book> GetBooks()
        {
            return _bookService.GetBooks();
        }

        [HttpPut]
        public List<Book> TakeBook()
        {
            List<Book> books = _bookService.GetBooks();
            foreach(var book in books)
            {
                if (book.Status == Status.Available)
                {
                    book.Status = Status.Booked;
                }
            }
            books[1].Status = Status.Booked;
            return books;
        }
    }
}
