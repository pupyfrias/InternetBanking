using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.User
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Must input {0}")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Must input {0}")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool HasError { get; set; }
        public string Error { get; set; }
    }
}