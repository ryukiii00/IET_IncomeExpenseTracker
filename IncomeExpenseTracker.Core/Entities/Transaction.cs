using IncomeExpenseTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseTracker.Domain.Entities
{
    public class Transaction : AuditableEntity
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public Category? Category { get; set; }
        public string? Description { get; set; }
    }
}
