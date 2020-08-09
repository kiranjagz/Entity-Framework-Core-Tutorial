using EF.Core.Tutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Core.Tutorial.Database
{
    class KeyGenContext : DbContext
    {
        public DbSet<Randomizer> Randomizers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=KeyGenDB;Trusted_Connection=True;");
        }
    }
}
