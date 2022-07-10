namespace InternetBanking.Core.Applicacion.ViewsModels.CashAdvance
{
    public class CashAdvanceViewModel
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int CreditCardId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
    }
}
