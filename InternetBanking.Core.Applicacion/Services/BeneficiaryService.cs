using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.Beneficiary;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class BeneficiaryService : GenericService<Beneficiary, BeneficiaryViewModel, BeneficiarySaveViewModel>, IBeneficiaryService
    {
    }
}
