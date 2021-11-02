using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_CORS_newest.Models
{
    public class BooksDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(a => a.Id);
        }

        public DbSet<Book> Books { get; set; }

        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {

        }
    }
}
