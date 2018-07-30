using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Books> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>().HasData(
                new Books
                {
                    Id = 1,
                    Name = "Harry Potter"
                }
            );
        }

    }
}
