using InternetBanking.Core.Applicacion.ViewsModels.ProductType;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface IProductTypeService : IGenericService<ProductType,ProductTypeViewModel, ProductTypeSaveViewModel>
    {
    }
}
