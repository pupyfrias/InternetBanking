using AutoMapper;
using InternetBanking.Core.Applicacion.Intefaces.Repositories;
using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.Account;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class AccountService: GenericService<Account, AccountViewModel,AccountSaveViewModel>, IAccountService
    {
        public AccountService(IAccountRepository Accountrepository, IMapper mapper):base(Accountrepository, mapper)
        {

        }
    }
}
