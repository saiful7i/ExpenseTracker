using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class TransactionDB : DbContext
    {
        public TransactionDB (DbContextOptions<TransactionDB> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Category> Category { get; set; } = default!;
        public DbSet<WebApplication1.Models.Transaction> Transaction { get; set; } = default!;
    }
}
