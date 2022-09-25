using AutoMapper;
using IncomeExpenseTracker.Application.Features.Transactions.Queries.GetTransactionsList;
using IncomeExpenseTracker.Domain.Entities;

namespace IncomeExpenseTracker.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Transaction, TransactionsListVm>().ReverseMap();
        }
    }
}
