using InternetBanking.Core.Applicacion.ViewsModels.Account;
using InternetBanking.Core.Applicacion.ViewsModels.Client;
using InternetBanking.Core.Applicacion.ViewsModels.CreditCard;
using InternetBanking.Core.Applicacion.ViewsModels.Loan;
using InternetBanking.Core.Applicacion.ViewsModels.ProductType;
using InternetBanking.Core.Applicacion.ViewsModels.Transaction;
using System.Collections.Generic;

namespace InternetBanking.Core.Applicacion.ViewsModels.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public int ClientId { get; set; }
        public ClientViewModel Client { get; set; }
        public ProductTypeViewModel ProductType { get; set; }
        public CreditCardViewModel CreditCard { get; set; }
        public LoanViewModel Loan { get; set; }
        public AccountViewModel Account { get; set; }
        public ICollection<TransactionViewModel> Transactions { get; set; }
    }
}
