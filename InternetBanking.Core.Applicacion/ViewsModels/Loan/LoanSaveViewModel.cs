using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.Loan
{
    public class LoanSaveViewModel
    {
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int DestinationAccountId { get; set; }
        [Required]
        public decimal AmountApproved { get; set; }
        [Required]
        public decimal OutstandingBalace { get; set; }
        [Required]
        public decimal BalanceSettled { get; set; }
        [Required]
        public decimal InterestRate { get; set; }
    }
}
