using InternetBanking.Core.Applicacion.Dtos.Account;
using InternetBanking.Core.Applicacion.Dtos.Email;
using InternetBanking.Core.Applicacion.Enums;
using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Infrastructure.Identity.Services
{
    public class UserAccountService : IUserAccountService
    {
        private readonly IEmailService _emailService;
        private readonly SignInManager<ApplicationUser> _singInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserAccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> singInManager, IEmailService emailService)
        {
            _userManager = userManager;
            _singInManager = singInManager;
            _emailService = emailService;
        }

        public async Task<AuthentificationResponse> AuthenticateAsync(AuthentificationRequest request)
        {
            AuthentificationResponse response = new();
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                response.HasError = true;
                response.Error = $"No accout registrated with {request.Email}";
                return response;
            }

            var result = await _singInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);

            if (!result.Succeeded)
            {
                response.HasError = true;
                response.Error = $"Invalid credentials to {request.Email}";
                return response;
            }

            if (!user.EmailConfirmed)
            {
                response.HasError = true;
                response.Error = $"Account doesn't confirm to {request.Email}";
                return response;
            }

            var rolesList = await _userManager.GetRolesAsync(user).ConfigureAwait(false);
            response.Id = user.Id;
            response.Email = user.Email;
            response.IsVerifired = user.EmailConfirmed;
            response.Roles = rolesList.ToList();
            response.UserName = user.UserName;

            return response;
        }

        public async Task<string> ConfirmAccountAsync(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return "No account registered with this user";
            }

            token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return $"Account confirm to {user.Email}. Now you can Sign In";
            }
            else
            {
                return $"An error ocurred trying confirm your account";
            }
        }

        public async Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, string origin)
        {
            var response = new ForgotPasswordResponse { HasError = false };
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                response.HasError = true;
                response.Error = $"No accout registrated with {request.Email}";
                return response;
            }


            var verificationUri = await SendForgotPasswordURI(user, origin);
            await _emailService.SendAsync(new EmailRequest
            {
                To = user.Email,
                Body = $"Please reset your password account visiting this URL {verificationUri}",
                Subject = "Reset Password"
            });


            return response;
        }

        public async Task<RegisterResponse> RegisterBasicAsync(RegisterRequest request, string origin)
        {
            var response = new RegisterResponse { HasError = false };
            var userNameExistS = await _userManager.FindByNameAsync(request.UserName);

            if (userNameExistS != null)
            {
                response.HasError = true;
                response.Error = $"Already exits an Account with this User Name {request.UserName}";
                return response;
            }

            var emailExistS = await _userManager.FindByEmailAsync(request.Email);
            if (emailExistS != null)
            {
                response.HasError = true;
                response.Error = $"Already exits an Account with this Email {request.Email}";
                return response;
            }

            var user = new ApplicationUser
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                Email = request.Email

            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, Roles.Basic.ToString());
                var verificationUri = await SendVerificationEmailURI(user, origin);
                await _emailService.SendAsync(new EmailRequest
                {
                    To = user.Email,
                    Body = $"Please confirm your account visiting this URL {verificationUri}",
                    Subject = "Confirm Account"
                });
            }
            else
            {
                response.HasError = true;
                var errors = result.Errors.ToList();
                errors.ForEach(e => response.Error += $"- {e.Description}\n");
                return response;
            }

            return response;
        }

        public async Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request)
        {
            var response = new ResetPasswordResponse { HasError = false };
            var account = await _userManager.FindByEmailAsync(request.Email);

            if (account == null)
            {
                response.HasError = true;
                response.Error = $"No accout registrated with {request.Email}";
                return response;
            }

            var token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(request.Token));

            var result = await _userManager.ResetPasswordAsync(account, token, request.Password);

            if (!result.Succeeded)
            {
                response.HasError = true;
                response.Error = $"Password Reset SuccessFull";
                return response;
            }

            return response;

        }

        public async Task SignOutAsync()
        {
            await _singInManager.SignOutAsync();
        }
        private async Task<string> SendForgotPasswordURI(ApplicationUser user, string origin)
        {
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var uri = new Uri(string.Concat($"{origin}/", "User/ResetPassword"));
            var verificationUri = QueryHelpers.AddQueryString(uri.ToString(), "token", code);

            return verificationUri;
        }

        private async Task<string> SendVerificationEmailURI(ApplicationUser user, string origin)
        {
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var uri = new Uri(string.Concat($"{origin}/", "User/ConfirmEmail"));
            var verificationUri = QueryHelpers.AddQueryString(uri.ToString(), "userId", user.Id);
            verificationUri = QueryHelpers.AddQueryString(uri.ToString(), "token", code);

            return verificationUri;
        }
    }
}
