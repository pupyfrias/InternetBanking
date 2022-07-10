using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.Product
{
    public class ProductSaveViewModel
    {
        public int Id { get; set; }
        [Required]
        public int ProductTypeId { get; set; }
        [Required]
        public int ClientId { get; set; }
    }
}
