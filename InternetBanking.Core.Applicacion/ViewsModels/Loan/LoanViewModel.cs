using InternetBanking.Core.Applicacion.ViewsModels.Account;
using InternetBanking.Core.Applicacion.ViewsModels.Client;
using InternetBanking.Core.Applicacion.ViewsModels.Product;

namespace InternetBanking.Core.Applicacion.ViewsModels.Loan
{
    public class LoanViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int ProductId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal AmountApproved { get; set; }
        public decimal OutstandingBalace { get; set; }
        public decimal BalanceSettled { get; set; }
        public decimal InterestRate { get; set; }
        public AccountViewModel Account { get; set; }
        public ProductViewModel Product { get; set; }
        public ClientViewModel Client { get; set; }
    }
}
