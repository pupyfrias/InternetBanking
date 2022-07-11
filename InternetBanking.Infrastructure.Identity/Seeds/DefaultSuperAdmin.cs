using InternetBanking.Core.Applicacion.Enums;
using InternetBanking.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBanking.Infrastructure.Identity.Seeds
{
    public static class DefaultSuperAdmin
    {
        public static async Task SeedsAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser superAdimn = new ApplicationUser
            {
                UserName = "SuperAdimn",
                Email = "pupyfrias@gmail.com",
                EmailConfirmed = true,
                FirstName = "John",
                LastName = "Doe",
            };

            if (userManager.Users.All(x => x.Id != superAdimn.Id))
            {
                var user = await userManager.FindByEmailAsync(superAdimn.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(superAdimn, "123Pa$$word!");
                    await userManager.AddToRoleAsync(superAdimn, Roles.Basic.ToString());
                    await userManager.AddToRoleAsync(superAdimn, Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(superAdimn, Roles.SuperAdmin.ToString());

                }
            }
        }
    }
}
