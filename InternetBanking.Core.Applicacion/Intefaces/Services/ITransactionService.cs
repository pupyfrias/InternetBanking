using InternetBanking.Core.Applicacion.ViewsModels.Transaction;
using System.Transactions;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface ITransactionService : IGenericService<Transaction, TransactionViewModel, TransactionSaveViewModel>
    {
    }
}
