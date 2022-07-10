using AutoMapper;
using InternetBanking.Core.Applicacion.Intefaces.Repositories;
using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Applicacion.ViewsModels.Product;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Services
{
    public class ProductService : GenericService<Product, ProductViewModel, ProductSaveViewModel>, IProductService
    {
        public ProductService(IProductRepository productrepository, IMapper mapper) : base(productrepository, mapper)
        {

        }
    }
}
