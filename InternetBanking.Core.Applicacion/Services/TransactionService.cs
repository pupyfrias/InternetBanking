using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.Transaction;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class TransactionService : GenericService<Transaction, TransactionViewModel, TransactionSaveViewModel>, ITransactionService
    {
    }
}
