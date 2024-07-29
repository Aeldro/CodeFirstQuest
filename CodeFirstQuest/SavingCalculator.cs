using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstQuest
{
    internal static class SavingCalculator
    {
        public static double ConvertMonthRatingToYear(double rate)
        {
            return rate * 12;
        }

        public static double AnnualRatedAmount(double annualRatingPercent, double amount)
        {
            double annualRating = annualRatingPercent / 100;
            return annualRating * amount;
        }
    }
}
