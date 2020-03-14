using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFDAL.Models;
using EFDAL.Context;
namespace EFDAL.Context
{
    public class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-A63MUHA\SQLEXPRESS;Initial Catalog=Project;User ID=sa;Password=pass@word1");
        }
        DbSet<Project> projects { get; set; }
        DbSet<Employe> employes { get; set; }
    }
}
