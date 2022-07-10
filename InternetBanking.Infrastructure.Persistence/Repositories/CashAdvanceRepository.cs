using InternetBanking.Core.Domain.Entities;
using InternetBanking.Infrastructure.Persistence.Contexts;

namespace InternetBanking.Core.Applicacion.Intefaces.Repositories
{
    public class CashAdvanceRepository: GenericRepository<CashAdvance>, ICashAdvanceRepository
    {
        public CashAdvanceRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
