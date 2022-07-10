using InternetBanking.Core.Applicacion.ViewsModels.Beneficiary;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface IBeneficiaryService : IGenericService<Beneficiary,BeneficiaryViewModel, BeneficiarySaveViewModel>
    {
    }
}
