using InternetBanking.Core.Applicacion.Dtos.Account;
using InternetBanking.Core.Applicacion.ViewsModels.Client;
using InternetBanking.Core.Applicacion.ViewsModels.User;
using System.Threading.Tasks;

namespace InternetBanking.Core.Applicacion.Services
{
    public interface IClientService
    {
        Task<string> ConfirmEmailAsync(string userId, string token);
        Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordSaveViewModel vm, string origin);
        Task<AuthentificationResponse> LoginAsync(LoginViewModel vm);
        Task<RegisterResponse> RegisterAsync(UserSaveViewModel vm, string origin);
        Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordSaveViewModel vm);
        Task SignOutAsync();
    }
}