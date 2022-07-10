using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.CreditCard;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class CreditCardService : GenericService<CreditCard, CreditCardViewModel, CreditCardSaveViewModel>, ICreditCardService
    {
    }
}
