namespace InternetBanking.Core.Applicacion.ViewsModels.Payment
{
    public class PaymentViewModel
    {
        public int ClientId { get; set; }
        public int OriginAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
