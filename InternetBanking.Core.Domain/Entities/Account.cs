using InternetBanking.Core.Domain.Common;
using System.Collections.Generic;

namespace InternetBanking.Core.Domain.Entities
{
    public class Account: AuditableBaseEntity
    {
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public decimal Balance { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }
        public  ICollection<Loan> Loans { get; set; }
        public ICollection<CashAdvance> CashAdvances { get; set; }
        public ICollection<Payment> PaymentsOriginAccount { get; set; }
        public ICollection<Payment> PaymentsDestinationAccount { get; set; }
        public ICollection<Transaction> TransactionsOriginAccount { get; set; }
        public ICollection<Transaction> TransactionsDestinationAccount { get; set; }

    }
}
