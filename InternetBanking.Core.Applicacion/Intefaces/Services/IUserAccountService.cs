using InternetBanking.Core.Applicacion.Dtos.Account;
using System.Threading.Tasks;

namespace InternetBanking.Infrastructure.Identity.Services
{
    public interface IUserAccountService
    {
        Task<AuthentificationResponse> AuthenticateAsync(AuthentificationRequest request);
        Task<string> ConfirmAccountAsync(string userId, string token);
        Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, string origin);
        Task<RegisterResponse> RegisterBasicAsync(RegisterRequest request, string origin);
        Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request);
        Task SignOutAsync();
    }
}