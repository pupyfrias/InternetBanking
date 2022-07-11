using InternetBanking.Infrastructure.Identity.Models;
using InternetBanking.Infrastructure.Identity.Seeds;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace InternetBanking.WebApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           var host =  CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var userManeger = services.GetRequiredService<UserManager<ApplicationUser>>();
                    var roleManeger = services.GetRequiredService<RoleManager<IdentityRole>>();

                    await DefaultRole.SeedsAsync(userManeger, roleManeger);
                    await DefaultSuperAdmin.SeedsAsync(userManeger, roleManeger);
                    await DefaultBasicUser.SeedsAsync(userManeger, roleManeger);
                }
                catch(Exception e)
                {

                } 
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
