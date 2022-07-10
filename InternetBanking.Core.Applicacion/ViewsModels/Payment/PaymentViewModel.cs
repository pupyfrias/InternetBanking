using InternetBanking.Core.Applicacion.ViewsModels.Account;
using InternetBanking.Core.Applicacion.ViewsModels.Client;

namespace InternetBanking.Core.Applicacion.ViewsModels.Payment
{
    public class PaymentViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int OriginAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public AccountViewModel OriginAccount { get; set; }
        public AccountViewModel DestinationAccount { get; set; }
        public ClientViewModel Client { get; set; }
    }
}
