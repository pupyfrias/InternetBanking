using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.Payment;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class PaymentService : GenericService<Payment, PaymentViewModel, PaymentSaveViewModel>, IPaymentService
    {
    }
}
