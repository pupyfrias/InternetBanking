using AutoMapper;
using InternetBanking.Core.Applicacion.Intefaces.Repositories;
using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.Beneficiary;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class BeneficiaryService : GenericService<Beneficiary, BeneficiaryViewModel, BeneficiarySaveViewModel>, IBeneficiaryService
    {
        public BeneficiaryService(IBeneficiaryRepository beneficiaryrepository, IMapper mapper) : base(beneficiaryrepository, mapper)
        {

        }
    }
}
