using IncomeExpenseTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseTracker.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public string? Name { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
    }
}
