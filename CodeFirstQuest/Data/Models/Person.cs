using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstQuest.Data.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<SavingAccount> SavingAccounts { get; set; } = new List<SavingAccount>();
    }
}
