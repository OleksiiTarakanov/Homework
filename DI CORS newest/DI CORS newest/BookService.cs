using DI_CORS_newest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_CORS_newest
{
    public class BookService : IBookService
    {
        private readonly BooksDbContext _context;

        public BookService(BooksDbContext context)
        {
            _context = context; 
        }
        public async Task<List<Book>> GetBooks()
        {
            var result = await _context.Books.ToListAsync();

            return result;
        }

        public async Task UpdateBookStatus(int id)
        {
            var book = await _context.Books.Where(book => book.Id == id).SingleOrDefaultAsync();
            book.Status = Status.Booked;
            await _context.SaveChangesAsync();
        }
    }
}
