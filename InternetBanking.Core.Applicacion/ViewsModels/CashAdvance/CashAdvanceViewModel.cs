using InternetBanking.Core.Applicacion.ViewsModels.Account;
using InternetBanking.Core.Applicacion.ViewsModels.Client;
using InternetBanking.Core.Applicacion.ViewsModels.CreditCard;

namespace InternetBanking.Core.Applicacion.ViewsModels.CashAdvance
{
    public class CashAdvanceViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int CreditCardId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
        public AccountViewModel Account { get; set; }
        public CreditCardViewModel CreditCard { get; set; }
        public ClientViewModel Client { get; set; }
    }
}
