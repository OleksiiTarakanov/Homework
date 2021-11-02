using DI_CORS_newest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_CORS_newest.Controllers
{
    [ApiController]
    public class TakeBooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public TakeBooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPut("books/{bookId}/status")]
        public async Task<IActionResult> UpdateBookStatus([FromRoute] int bookId)
        {
            await _bookService.UpdateBookStatus(bookId);

            return Ok();
        }
    }
}
