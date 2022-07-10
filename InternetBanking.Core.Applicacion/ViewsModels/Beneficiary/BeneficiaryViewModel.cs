using InternetBanking.Core.Applicacion.ViewsModels.Client;

namespace InternetBanking.Core.Applicacion.ViewsModels.Beneficiary
{
    public class BeneficiaryViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int BeneficiaryId { get; set; }
        public string ClientName { get; set; }
        public string BeneficiaryName { get; set; }
        public ClientViewModel Client { get; set; }
        public ClientViewModel ClientBeneficiary { get; set; }
    }
}
