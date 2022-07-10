using InternetBanking.Core.Domain.Common;
using System.Collections.Generic;

namespace InternetBanking.Core.Domain.Entities
{
    public class Loan: AuditableBaseEntity
    {
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal AmountApproved { get; set; }
        public decimal OutstandingBalace { get; set; }
        public decimal BalanceSettled { get; set; }
        public decimal InterestRate { get; set; }
        public Account Account { get; set; }
        public Product Product { get; set; }
        public Client Client { get; set; }
    }
}
