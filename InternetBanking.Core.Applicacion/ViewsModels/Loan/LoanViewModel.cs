namespace InternetBanking.Core.Applicacion.ViewsModels.Loan
{
    public class LoanViewModel
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int ProductId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal AmountApproved { get; set; }
        public decimal OutstandingBalace { get; set; }
        public decimal BalanceSettled { get; set; }
        public decimal InterestRate { get; set; }
    }
}
