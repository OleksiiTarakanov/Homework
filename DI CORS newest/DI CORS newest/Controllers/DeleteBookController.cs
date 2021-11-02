using DI_CORS_newest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_CORS_newest.Controllers
{
    [Route("DeleteBook")]
    [ApiController]
    public class DeleteBookController : ControllerBase
    {
        private readonly BooksDbContext _context;

        public DeleteBookController(BooksDbContext context)
        {
            _context = context;
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBook([FromServices] IBookService bookService, int id)
        {
            var booklist = await bookService.GetBooks();
            booklist.RemoveAt(id-1);
            return Ok(booklist);
        }
    }
}
