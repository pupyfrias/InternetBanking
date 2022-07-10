using InternetBanking.Core.Applicacion.ViewsModels.CashAdvance;
using InternetBanking.Core.Applicacion.ViewsModels.Client;
using InternetBanking.Core.Applicacion.ViewsModels.Product;
using System.Collections.Generic;

namespace InternetBanking.Core.Applicacion.ViewsModels.CreditCard
{
    public class CreditCardViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int ProductId { get; set; }
        public decimal Limit { get; set; }
        public decimal BalanceToDate { get; set; }
        public decimal AvalableBalance { get; set; }
        public ProductViewModel Product { get; set; }
        public ClientViewModel Client { get; set; }
        public ICollection<CashAdvanceViewModel> CashAdvances { get; set; }
    }
}
