using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email është i detyrueshëm")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Fjalëkalimi është i detyrueshëm")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }
}