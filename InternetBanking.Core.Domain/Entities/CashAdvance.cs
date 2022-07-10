using InternetBanking.Core.Domain.Common;
using System;

namespace InternetBanking.Core.Domain.Entities
{
    public class CashAdvance: AuditableBaseEntity
    {
        public int ClientId { get; set; }
        public int CreditCardId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
        public Account Account { get; set; }
        public CreditCard CreditCard { get; set; }
        public Client Client { get; set; }
    }
}
