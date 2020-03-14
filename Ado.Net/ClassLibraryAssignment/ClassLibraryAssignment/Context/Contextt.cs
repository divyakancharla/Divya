using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ClassLibraryAssignment.Context;
using ClassLibraryAssignment.Models;
namespace ClassLibraryAssignment.Context
{
    public class Contextt : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-A63MUHA\SQLEXPRESS;Initial Catalog=Project;User ID=sa;Password=pass@word1");
        }
       public DbSet<Item> items { get; set; }
       public DbSet<Order> orders { get; set; }
    }
}
