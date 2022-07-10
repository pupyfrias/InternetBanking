using InternetBanking.Core.Applicacion.ViewsModels.CashAdvance;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface ICashAdvanceService : IGenericService<CashAdvance,CashAdvanceViewModel, CashAdvanceSaveViewModel>
    {
    }
}
