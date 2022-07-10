using AutoMapper;
using InternetBanking.Core.Applicacion.Intefaces.Repositories;
using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.ProductType;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class ProductTypeService: GenericService<ProductType, ProductTypeViewModel,ProductTypeSaveViewModel>, IProductTypeService
    {
        public ProductTypeService(IProductTypeRepository productTyperepository, IMapper mapper) : base(productTyperepository, mapper)
        {

        }
    }
}
