using InternetBanking.Core.Applicacion.ViewsModels.Account;
using InternetBanking.Core.Applicacion.ViewsModels.Beneficiary;
using InternetBanking.Core.Applicacion.ViewsModels.CashAdvance;
using InternetBanking.Core.Applicacion.ViewsModels.CreditCard;
using InternetBanking.Core.Applicacion.ViewsModels.Loan;
using InternetBanking.Core.Applicacion.ViewsModels.Payment;
using InternetBanking.Core.Applicacion.ViewsModels.Product;
using InternetBanking.Core.Applicacion.ViewsModels.Transaction;
using System.Collections.Generic;

namespace InternetBanking.Core.Applicacion.ViewsModels.Client
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AccountViewModel> Accounts { get; set; }
        public ICollection<BeneficiaryViewModel> Beneficiaries { get; set; }
        public ICollection<BeneficiaryViewModel> ClientsBeneficiaries { get; set; }
        public ICollection<CreditCardViewModel> CreditCards { get; set; }
        public ICollection<LoanViewModel> Loans { get; set; }
        public ICollection<PaymentViewModel> Payments { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
        public ICollection<TransactionViewModel> Transactions { get; set; }
        public ICollection<CashAdvanceViewModel> CashAdvances { get; set; }
    }
}
