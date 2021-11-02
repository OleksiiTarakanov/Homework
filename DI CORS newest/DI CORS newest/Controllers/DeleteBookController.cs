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
        [HttpDelete]
        public List<Book> DeleteBook([FromServices] IBookService bookService, int id)
        {
            var bookList = bookService.GetBooks();
            bookList.RemoveAt(id-1);
            return bookList;
        }
    }
}
