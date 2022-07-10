namespace InternetBanking.Core.Applicacion.ViewsModels.CreditCard
{
    public class CreditCardViewModel
    {
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public decimal Limit { get; set; }
        public decimal BalanceToDate { get; set; }
        public decimal AvalableBalance { get; set; }
    }
}
