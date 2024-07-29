using CodeFirstQuest.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstQuest.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=127.0.0.1,1433;Database=CodeFirstQuestDb;User Id=SA;Password=MyPass@word;Integrated security=False;TrustServerCertificate=True;");
        }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<SavingAccount> SavingAccounts { get; set; }
    }
}
