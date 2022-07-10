using AutoMapper;
using InternetBanking.Core.Applicacion.Intefaces.Repositories;
using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.CashAdvance;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class CashAdvanceService : GenericService<CashAdvance, CashAdvanceViewModel, CashAdvanceSaveViewModel>, ICashAdvanceService
    {
        public CashAdvanceService(ICashAdvanceRepository cashAdvancerepository, IMapper mapper) : base(cashAdvancerepository, mapper)
        {

        }
    }
}
