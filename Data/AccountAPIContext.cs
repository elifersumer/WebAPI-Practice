using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AccountAPI.Models
{
    public class AccountAPIContext : DbContext
    {
        public AccountAPIContext (DbContextOptions<AccountAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }
    }
}
