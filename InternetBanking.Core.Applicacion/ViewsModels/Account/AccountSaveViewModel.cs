using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.Account
{
    public class AccountSaveViewModel
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public decimal Balance { get; set; }
    }
}
