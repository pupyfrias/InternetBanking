using InternetBanking.Core.Applicacion.ViewsModels.Payment;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface IPaymentService : IGenericService<Payment, PaymentViewModel, PaymentSaveViewModel>
    {
    }
}
