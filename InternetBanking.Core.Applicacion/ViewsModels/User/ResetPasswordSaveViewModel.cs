using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.Client
{
    public class ResetPasswordSaveViewModel
    {
        [Required(ErrorMessage ="Must to input {0}")]
        [DataType(DataType.Text)]
        public string Email { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool HasError { get; set; }
        public string Error { get; set; }
    }
}
