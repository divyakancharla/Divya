using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace CookiesndSessions.Models
{
    public class UserAccountContext:DbContext
    {
        public UserAccountContext(DbContextOptions<UserAccountContext> options) : base(options)
        {

        }
        public DbSet<UserAccount> userAccounts { get; set; }
    }
}
