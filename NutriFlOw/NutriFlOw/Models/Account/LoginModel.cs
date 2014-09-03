using System.ComponentModel.DataAnnotations;

namespace NutriFlOw.Models.Account
{
    public class LoginModel
    {
        [Display(Name = "E-Mail: ")]
        [Required(ErrorMessage = "Required Field")]
        public string EMail { get; set; }

        [Display(Name = "Password: ")]
        [Required(ErrorMessage = "Required Field")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}