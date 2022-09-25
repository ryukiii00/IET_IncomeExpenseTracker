using AutoMapper;
using IncomeExpenseTracker.Application.Contracts.Persistence;
using IncomeExpenseTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseTracker.Application.Features.Transactions.Queries.GetTransactionsList
{
    public class GetTransactionsListQuery : IRequest<List<TransactionsListVm>>
    {
    }

    public class GetTransactionsListQueryHandler : IRequestHandler<GetTransactionsListQuery, List<TransactionsListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Transaction> _transactionRepository;

        public GetTransactionsListQueryHandler(IMapper mapper, IAsyncRepository<Transaction> transactionRepository)
        {
            _mapper = mapper;
            _transactionRepository = transactionRepository;
        }

        public async Task<List<TransactionsListVm>> Handle(GetTransactionsListQuery request, CancellationToken cancellationToken)
        {
            var allTrasactions = await _transactionRepository.GetAllAsync();
            return _mapper.Map<List<TransactionsListVm>>(allTrasactions);
        }
    }
}
