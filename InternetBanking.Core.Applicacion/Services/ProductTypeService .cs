using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.ProductType;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class ProductTypeService: GenericService<ProductType, ProductTypeViewModel,ProductTypeSaveViewModel>, IProductTypeService
    {
    }
}
