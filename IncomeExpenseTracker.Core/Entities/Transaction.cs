using IncomeExpenseTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseTracker.Domain.Entities
{
    public class Transaction : AuditableEntity
    {
        private Transaction(Guid id, double value, Category category, string description)
        {
            Id = id;
            Value = value;
            Category = category;
            Description = description;
        }

        public Guid Id { get; private set; }
        public double Value { get; private set; }
        public Category? Category { get; private set; }
        public string? Description { get; private set; }

        public static Transaction NewIncome(double value, string description)
        {
            return new Transaction(Guid.NewGuid(), value, Common.Category.Income, description);
        }

        public static Transaction NewExpense(double value, string description)
        {
            return new Transaction(Guid.NewGuid(), value, Common.Category.Expense, description);
        }


        //public static double GetDailyDifferenceInWeek(DateTime firstDayWeek, IList<Transaction> transactions)
        //{
        //    if (firstDayWeek.Date.DayOfWeek != DayOfWeek.Monday)
        //        throw new ArgumentException("Error! The first day of the chart is not monday.");

        //    var SundayOfWeek = firstDayWeek.AddDays(6);

        //    var WeeklyIncomes = transactions.Where(x =>
        //                                 x.CreationDate.Month == firstDayWeek.Month &&
        //                                    x.CreationDate.Date >= firstDayWeek.Date &&
        //                                        x.CreationDate.Date <= SundayOfWeek.Date &&
        //                                            x.Category == Domain.Common.Category.Income)
        //                                        .OrderBy(x => x.CreationDate);

        //    var WeeklyExpenses = transactions.Where(x =>
        //                     x.CreationDate.Month == firstDayWeek.Month &&
        //                        x.CreationDate.Date >= firstDayWeek.Date &&
        //                            x.CreationDate.Date <= SundayOfWeek.Date &&
        //                                x.Category == Domain.Common.Category.Expense)
        //                            .OrderBy(x => x.CreationDate);

        //    double diff = 0;

        //    for(var x = 1; x <= 7; x++ )
        //    {
        //        if(WeeklyExpenses.ElementAt(x).CreationDate == WeeklyIncomes.ElementAt(x).CreationDate)
        //        {
        //            diff = WeeklyIncomes.ElementAt(x).Value - WeeklyExpenses.ElementAt(x).Value;
        //            var dayCount = firstDayWeek.AddDays(x++);
        //        }

                
        //        // prob not worth
        //    }
        //}
    }
}