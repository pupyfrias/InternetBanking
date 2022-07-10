using AutoMapper;
using InternetBanking.Core.Applicacion.Intefaces.Repositories;
using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.Transaction;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class TransactionService : GenericService<Transaction, TransactionViewModel, TransactionSaveViewModel>, ITransactionService
    {
        public TransactionService(ITransactionRepository transactionrepository, IMapper mapper) : base(transactionrepository, mapper)
        {

        }
    }
}
