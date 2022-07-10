using InternetBanking.Core.Domain.Common;
using System.Collections.Generic;

namespace InternetBanking.Core.Domain.Entities
{
    public class ProductType: AuditableBaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
