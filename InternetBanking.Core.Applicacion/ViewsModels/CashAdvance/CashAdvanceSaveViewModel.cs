using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.CashAdvance
{
    public class CashAdvanceSaveViewModel
    {
        public int ClientId { get; set; }
        [Required]
        public int CreditCardId { get; set; }
        [Required]
        public int DestinationAccountId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public decimal InterestRate { get; set; }
    }
}
