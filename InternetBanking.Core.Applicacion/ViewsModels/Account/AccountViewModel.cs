using InternetBanking.Core.Applicacion.ViewsModels.CashAdvance;
using InternetBanking.Core.Applicacion.ViewsModels.Client;
using InternetBanking.Core.Applicacion.ViewsModels.Loan;
using InternetBanking.Core.Applicacion.ViewsModels.Payment;
using InternetBanking.Core.Applicacion.ViewsModels.Product;
using InternetBanking.Core.Applicacion.ViewsModels.Transaction;
using System.Collections.Generic;

namespace InternetBanking.Core.Applicacion.ViewsModels.Account
{
    public class AccountViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public decimal Balance { get; set; }
        public ClientViewModel Client { get; set; }
        public ProductViewModel Product { get; set; }
        public ICollection<LoanViewModel> Loans { get; set; }
        public ICollection<CashAdvanceViewModel> CashAdvances { get; set; }
        public ICollection<PaymentViewModel> PaymentsOriginAccount { get; set; }
        public ICollection<PaymentViewModel> PaymentsDestinationAccount { get; set; }
        public ICollection<TransactionViewModel> TransactionsOriginAccount { get; set; }
        public ICollection<TransactionViewModel> TransactionsDestinationAccount { get; set; }
    }
}
