using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee2.Models;

namespace Employee2.Data
{
    public class Employee2Context : DbContext
    {
        public Employee2Context (DbContextOptions<Employee2Context> options)
            : base(options)
        {
        }

        public DbSet<Employee2.Models.Employee> Employee { get; set; }
    }
}
