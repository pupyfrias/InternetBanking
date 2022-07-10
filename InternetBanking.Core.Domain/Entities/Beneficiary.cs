using InternetBanking.Core.Domain.Common;

namespace InternetBanking.Core.Domain.Entities
{
    public class Beneficiary: AuditableBaseEntity   
    {
        public int ClientId { get; set; }
        public int BeneficiaryId { get; set; }
        public Client Client { get; set; }

        public Client ClientBeneficiary { get; set; }

    }
}
