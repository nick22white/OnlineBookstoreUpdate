using System;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstore.Models
{
    public class BookstoreDbContext : DbContext
    {
        //Extends the base
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base (options)
        {

        }

        //Query and save Books
        public DbSet<Book> Books { get; set; }
    }
}
