using InternetBanking.Core.Domain.Common;
using System.Collections.Generic;

namespace InternetBanking.Core.Domain.Entities
{
    public class CreditCard: AuditableBaseEntity
    {
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public  decimal Limit{ get; set; }
        public decimal BalanceToDate { get; set; }
        public decimal AvalableBalance { get; set; }
        public Product Product { get; set; }
        public Client Client { get; set; }
        public ICollection<CashAdvance> CashAdvances { get; set; }
    }
}
