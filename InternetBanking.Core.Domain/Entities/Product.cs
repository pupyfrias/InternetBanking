using InternetBanking.Core.Domain.Common;
using System.Collections.Generic;

namespace InternetBanking.Core.Domain.Entities
{
    public class Product : AuditableBaseEntity
    {
        public int ProductTypeId { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public ProductType  ProductType{ get; set; }
        public CreditCard   CreditCard { get; set; }
        public  Loan Loan{ get; set; }
        public Account Account  { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

    }
}
