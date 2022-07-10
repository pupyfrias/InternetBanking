using InternetBanking.Core.Applicacion.Intefaces.Repositories;
using InternetBanking.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternetBanking.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructurePersitence(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ApplicationContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName));

            });

            #region Repositories
            service.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddTransient<IAccountRepository, AccountRepository>();
            service.AddTransient<IBeneficiaryRepository, BeneficiaryRepository>();
            service.AddTransient<ICashAdvanceRepository, CashAdvanceRepository>();
            service.AddTransient<IClientRepository, ClientRepository>();
            service.AddTransient<ICreditCardRepository, CreditCardRepository>();
            service.AddTransient<ILoanRepository, LoanRepository>();
            service.AddTransient<IPaymentRepository, PaymentRepository>();
            service.AddTransient<IProductRepository,ProductRepository>();
            service.AddTransient<IProductTypeRepository,ProductTypeRepository>();
            service.AddTransient<ITransactionRepository, TransactionRepository>();
            #endregion
        }
    }
}
