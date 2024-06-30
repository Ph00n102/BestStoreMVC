using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestStoreMVC1.Models;
using Microsoft.EntityFrameworkCore;

namespace BestStoreMVC1.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}