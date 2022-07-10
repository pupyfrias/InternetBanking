using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.Client;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class ClientService : GenericService<Client, ClientViewModel, ClientSaveViewModel>, IClientService
    {
    }
}
