using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.Transaction
{
    public class TransactionSaveViewModel
    {
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int OriginAccountId { get; set; }
        [Required]
        public int DestinationAccountId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
