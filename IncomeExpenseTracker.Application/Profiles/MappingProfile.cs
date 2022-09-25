using AutoMapper;
using IncomeExpenseTracker.Application.Features.Transactions.Queries.GetTransactionsList;

namespace IncomeExpenseTracker.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Entities.Transaction, TransactionsListVm>().ReverseMap();
        }
    }
}
