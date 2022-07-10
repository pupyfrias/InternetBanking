using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternetBanking.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection service, IConfiguration configuration)
        {
            #region Services
            service.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            service.AddTransient<IAccountService, AccountService>();
            service.AddTransient<IBeneficiaryService, BeneficiaryService>();
            service.AddTransient<ICashAdvanceService, CashAdvanceService>();
            service.AddTransient<IClientService, ClientService>();
            service.AddTransient<ICreditCardService, CreditCardService>();
            service.AddTransient<ILoanService, LoanService>();
            service.AddTransient<IPaymentService, PaymentService>();
            service.AddTransient<IProductService, ProductService>();
            service.AddTransient<IProductTypeService, ProductTypeService>();
            service.AddTransient<ITransactionService, TransactionService>();
            #endregion
        }
    }
}
