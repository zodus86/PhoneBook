using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<PhoneBooks> phoneBooks { get; set; }
    }
}
