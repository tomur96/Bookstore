using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models;

namespace Bookstore.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }

        public DbSet<Bookstore.Models.Book> Book { get; set; }
    }
}
