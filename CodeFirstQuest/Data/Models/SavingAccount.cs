using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstQuest.Data.Models
{
    internal class SavingAccount
    {
        public Guid Id { get; set; }
        public double AnnualPercentRate { get; set; }
        public double InitialAmount { get; set; }
    }
}
