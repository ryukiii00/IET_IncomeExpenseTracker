using IncomeExpenseTracker.Domain.Common;

namespace IncomeExpenseTracker.Application.Features.Transactions.Queries.GetTransactionsList
{
    public class TransactionsListVm
    {
        public double Amount { get; set; }
        public Category? Category { get; set; }
        public string? Description { get; set; }
    }
}