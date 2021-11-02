using DI_CORS_newest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_CORS_newest.Controllers
{
    [Route("GetAllBooks")]
    [ApiController]
    public class GetBooksController : ControllerBase
    {
        private IBookService _bookService;
        List<Book> booksList = new List<Book>();
        private readonly BooksDbContext _context;

        public GetBooksController(BooksDbContext context)
        {
            _context = context;
        }

        public IBookService bookService
        {
            get => _bookService ?? (_bookService = new BookService(_context));
            set
            {
                if (_bookService != null)
                    throw new InvalidOperationException(nameof(value));


                _bookService = value ?? throw new ArgumentNullException(nameof(value));
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var res = await bookService.GetBooks();
            return Ok(res);
        }

        [HttpPost("AddBook")]
        public async Task<IActionResult> AddBookToList([FromForm] Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();


            return NoContent();
        }

    }
}



