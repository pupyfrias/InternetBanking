using InternetBanking.Core.Applicacion.ViewsModels.Product;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface IProductService : IGenericService<Product,ProductViewModel, ProductSaveViewModel>
    {
    }
}
