using InternetBanking.Core.Applicacion.Enums;
using InternetBanking.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBanking.Infrastructure.Identity.Seeds
{
    public static class DefaultBasicUser
    {
        public static async Task SeedsAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser basicUser = new ApplicationUser
            {
                UserName = "BasicUser",
                Email = "20174594@itla.edu.do",
                EmailConfirmed = true,
                FirstName = "John",
                LastName = "Doe",
            };

            if (userManager.Users.All(x => x.Id != basicUser.Id))
            {
                var user = await userManager.FindByEmailAsync(basicUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(basicUser, "123Pa$$word!");
                    await userManager.AddToRoleAsync(basicUser, Roles.Basic.ToString());

                }
            }
        }
    }
}
