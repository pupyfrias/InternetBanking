using AutoMapper;
using InternetBanking.Core.Applicacion.Intefaces.Repositories;
using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.Loan;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class LoanService : GenericService<Loan, LoanViewModel, LoanSaveViewModel>, ILoanService
    {
        public LoanService(ILoanRepository loanrepository, IMapper mapper) : base(loanrepository, mapper)
        {

        }
    }
}
