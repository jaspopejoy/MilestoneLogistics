using System.ComponentModel.DataAnnotations;

namespace MilestoneLogistics.web.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
