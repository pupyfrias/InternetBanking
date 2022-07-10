using InternetBanking.Core.Applicacion.ViewsModels.Account;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface IAccountService: IGenericService<Account,AccountViewModel, AccountSaveViewModel>
    {
    }
}
