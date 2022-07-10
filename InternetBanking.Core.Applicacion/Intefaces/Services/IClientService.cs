using InternetBanking.Core.Applicacion.ViewsModels.Client;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface IClientService : IGenericService<Client, ClientViewModel, ClientSaveViewModel>
    {
    }
}
