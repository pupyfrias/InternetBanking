using InternetBanking.Core.Domain.Entities;
using InternetBanking.Infrastructure.Persistence.Contexts;

namespace InternetBanking.Core.Applicacion.Intefaces.Repositories
{
    public class AccountRepository: GenericRepository<Account>,IAccountRepository
    {
        public AccountRepository(ApplicationContext context): base(context)
        {

        }
    }
}
