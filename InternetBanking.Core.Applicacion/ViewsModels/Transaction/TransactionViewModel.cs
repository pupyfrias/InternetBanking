using InternetBanking.Core.Applicacion.ViewsModels.Account;
using InternetBanking.Core.Applicacion.ViewsModels.Client;
using InternetBanking.Core.Applicacion.ViewsModels.Product;


namespace InternetBanking.Core.Applicacion.ViewsModels.Transaction
{
    public class TransactionViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int ProductId { get; set; }
        public int OriginAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public ClientViewModel Client { get; set; }
        public ProductViewModel Product { get; set; }
        public AccountViewModel OriginAccount { get; set; }
        public AccountViewModel DestinationAccount { get; set; }
    }
}
