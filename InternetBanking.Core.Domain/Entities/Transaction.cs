using InternetBanking.Core.Domain.Common;
using System.Collections.Generic;

namespace InternetBanking.Core.Domain.Entities
{
    public class Transaction: AuditableBaseEntity
    {
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int OriginAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }
        public Account OriginAccount { get; set; }
        public Account DestinationAccount { get; set; }
    }
}
