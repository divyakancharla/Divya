using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCoreIntro.Models;
namespace EntityFrameworkCoreIntro
{
    class Context:DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-A63MUHA\SQLEXPRESS;Initial Catalog=StudentDB;User ID=sa;Password=pass@word1");
        }
    }
}
