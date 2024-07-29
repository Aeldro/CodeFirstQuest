using CodeFirstQuest.Data;
using CodeFirstQuest.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                // I wipe out my database at each execution
                context.Database.EnsureDeleted();
                // Then I recreate it
                context.Database.EnsureCreated();

                var person = new Person
                {
                    Name = "Richard"
                };

                person.SavingAccounts = new List<SavingAccount>
                {
                new SavingAccount
                {
                    Id = Guid.NewGuid(),
                    AnnualPercentRate = SavingCalculator.ConvertMonthRatingToYear(5),
                    InitialAmount = 2000000,
                },
                new SavingAccount
                {
                    Id = Guid.NewGuid(),
                    AnnualPercentRate = 15,
                    InitialAmount = 250000,
                },
                new SavingAccount
                {
                    Id = Guid.NewGuid(),
                    AnnualPercentRate = 2,
                    InitialAmount = 10000000,
                }
                };

                context.Add(person);
                context.SaveChanges();

            }

            using (var context = new ApplicationDbContext())
            {
                foreach (var account in context.SavingAccounts)
                {
                    Console.WriteLine($"Account: {account.Id}");
                    Console.WriteLine($"Rate: {SavingCalculator.AnnualRatedAmount(account.AnnualPercentRate, account.InitialAmount)} euros");
                }
            }

        }
    }
}
