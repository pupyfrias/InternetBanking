using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.Transaction
{
    public class TransactionViewModel
    {
        
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int OriginAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
