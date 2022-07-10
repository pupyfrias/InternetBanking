using InternetBanking.Core.Domain.Common;
using System;

namespace InternetBanking.Core.Domain.Entities
{
    public class Payment: AuditableBaseEntity
    {
        public int ClientId { get; set; }
        public int OriginAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public Account OriginAccount { get; set; }
        public Account DestinationAccount { get; set; }
        public Client Client { get; set; }
    }
}
