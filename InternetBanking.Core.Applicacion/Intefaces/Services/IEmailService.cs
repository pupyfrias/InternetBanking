using InternetBanking.Core.Applicacion.Dtos.Email;
using System.Threading.Tasks;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
