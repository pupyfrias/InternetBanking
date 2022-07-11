using Microsoft.AspNetCore.Identity;

namespace InternetBanking.Infrastructure.Identity.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
