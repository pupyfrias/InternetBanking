using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.Beneficiary
{
    public class BeneficiarySaveViewModel
    {
        public int ClientId { get; set; }
        [Required]
        public int BeneficiaryId { get; set; }
    }
}
