using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.ProductType
{
    public class ProductTypeSaveViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
