using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Domain.Settings;
using InternetBanking.Infrastructure.Shared.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternetBanking.Infrastructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureShared(this IServiceCollection service, IConfiguration configuration)
        {
            service.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            service.AddTransient<IEmailService, EmailService>();
        }
    }
}
