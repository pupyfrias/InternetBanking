using InternetBanking.Core.Applicacion.ViewsModels.CreditCard;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface ICreditCardService : IGenericService<CreditCard, CreditCardViewModel, CreditCardSaveViewModel>
    {
    }
}
