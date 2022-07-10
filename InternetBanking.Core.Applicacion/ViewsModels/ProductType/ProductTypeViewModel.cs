using InternetBanking.Core.Applicacion.ViewsModels.Product;
using System.Collections.Generic;

namespace InternetBanking.Core.Applicacion.ViewsModels.ProductType
{
    public class ProductTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductViewModel> Product { get; set; }
    }
}
