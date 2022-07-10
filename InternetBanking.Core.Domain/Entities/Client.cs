using InternetBanking.Core.Domain.Common;
using System.Collections.Generic;

namespace InternetBanking.Core.Domain.Entities
{
    public class Client: AuditableBaseEntity
    {
        public string Name { get; set; }
        public ICollection<Account> Accounts { get; set; }
        public ICollection<Beneficiary> Beneficiaries{ get; set; }
        public ICollection<Beneficiary> ClientsBeneficiaries{ get; set; }
        public ICollection<CreditCard> CreditCards { get; set; }
        public ICollection<Loan> Loans { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<CashAdvance> CashAdvances{ get; set; }
    }
}
