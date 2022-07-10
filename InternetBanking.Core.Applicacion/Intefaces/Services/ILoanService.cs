using InternetBanking.Core.Applicacion.ViewsModels.Loan;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface ILoanService : IGenericService<Loan, LoanViewModel, LoanSaveViewModel>
    {
    }
}
