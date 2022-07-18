using AutoMapper;
using InternetBanking.Core.Applicacion.Dtos.Account;
using InternetBanking.Core.Applicacion.ViewsModels.Client;
using InternetBanking.Core.Applicacion.ViewsModels.User;
using InternetBanking.Infrastructure.Identity.Services;
using System.Threading.Tasks;

namespace InternetBanking.Core.Applicacion.Services
{
    public class ClientService : IClientService
    {
        private readonly IMapper _mapper;
        private readonly IUserAccountService _serviceAccout;
        public ClientService(IUserAccountService serviceAccount, IMapper mapper)
        {
            _mapper = mapper;
            _serviceAccout = serviceAccount;
        }


        public async Task<string> ConfirmEmailAsync(string userId, string token)
        {
            return await _serviceAccout.ConfirmAccountAsync(userId, token);
        }

        public async Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordSaveViewModel vm, string origin)
        {
            var forgotPasswordRequest = _mapper.Map<ForgotPasswordRequest>(vm);
            return await _serviceAccout.ForgotPasswordAsync(forgotPasswordRequest, origin);
        }

        public async Task<AuthentificationResponse> LoginAsync(LoginViewModel vm)
        {
            var loginRequest = _mapper.Map<AuthentificationRequest>(vm);
            return await _serviceAccout.AuthenticateAsync(loginRequest);
        }

        public async Task<RegisterResponse> RegisterAsync(UserSaveViewModel vm, string origin)
        {
            var registerRequest = _mapper.Map<RegisterRequest>(vm);
            return await _serviceAccout.RegisterBasicAsync(registerRequest, origin);
        }
        public async Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordSaveViewModel vm)
        {
            var resetPasswordRequest = _mapper.Map<ResetPasswordRequest>(vm);
            return await _serviceAccout.ResetPasswordAsync(resetPasswordRequest);
        }

        public async Task SignOutAsync()
        {
            await _serviceAccout.SignOutAsync();
        }
    }
}