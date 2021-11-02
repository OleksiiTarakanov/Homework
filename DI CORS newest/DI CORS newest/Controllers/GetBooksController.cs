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

        public IBookService bookService
        {
            get => _bookService ?? (_bookService = new BookService());
            set
            {
                if (_bookService != null)
                    throw new InvalidOperationException(nameof(value));


                _bookService = value ?? throw new ArgumentNullException(nameof(value));
            }
        }


        [HttpGet]
        public List<Book> GetAllBooks()
        {
            return bookService.GetBooks();
        }

    }
}



