using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Applicacion.ViewsModels.User
{
    public class UserSaveViewModel
    {
        [Required(ErrorMessage ="Must to input a {0}")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Must to input a {0}")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Must to input a {0}")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Must to input a {0}")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Must to input a {0}")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Must to input a {0}")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Must to input a {0}")]
        public string Phone { get; set; }
        public bool HasError { get; set; }
        public string Error { get; set; }
    }
}
