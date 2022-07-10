using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.Client
{
    public class ClientSaveViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
