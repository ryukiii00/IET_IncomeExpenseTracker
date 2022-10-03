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

        public static double CalculateDailyChartData(IList<Transaction>IncomeListByDay, IList<Transaction>ExpenseListByDay)
        {
            if (IncomeListByDay is null || ExpenseListByDay is null)
                throw new ArgumentNullException();

            double difference = 0;

            if (IncomeListByDay.Count > ExpenseListByDay.Count)
            {
                for(var i = 1; i <= IncomeListByDay.Count; i++)
                {
                    if(IncomeListByDay[i].Value > ExpenseListByDay[i].Value)
                    {
                        difference += (IncomeListByDay[i].Value - ExpenseListByDay[i].Value);
                    }
                    else
                    {
                        difference += (ExpenseListByDay[i].Value - IncomeListByDay[i].Value);
                    }
                }

                return difference;
            }
            else
            {
                for (var i = 1; i <= ExpenseListByDay.Count; i++)
                {
                    if (IncomeListByDay[i].Value > ExpenseListByDay[i].Value)
                    {
                        difference += (IncomeListByDay[i].Value - ExpenseListByDay[i].Value);
                    }
                    else
                    {
                        difference += (ExpenseListByDay[i].Value - IncomeListByDay[i].Value);
                    }
                }

                return difference;
            }
        }       
    }
}