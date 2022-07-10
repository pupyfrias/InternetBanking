using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.CreditCard
{
    public class CreditCardSaveViewModel
    {
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public decimal Limit { get; set; }
        [Required]
        public decimal BalanceToDate { get; set; }
        [Required]
        public decimal AvalableBalance { get; set; }
    }
}
