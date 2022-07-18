using InternetBanking.Infrastructure.Identity.Contexts;
using InternetBanking.Infrastructure.Identity.Models;
using InternetBanking.Infrastructure.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternetBanking.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureIdentity(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<IdentityContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("IdentityConnection"),
                m => m.MigrationsAssembly(typeof(IdentityContext).Assembly.FullName));

            });

            #region Identity
            service.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContext>()
                .AddDefaultTokenProviders();
            service.AddAuthentication();
            #endregion

            #region Service
            service.AddTransient<IUserAccountService, UserAccountService>();
            #endregion
        }
    }
}
