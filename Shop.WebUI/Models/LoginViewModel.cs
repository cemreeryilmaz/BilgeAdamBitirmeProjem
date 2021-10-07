using System.ComponentModel.DataAnnotations;

namespace Shop.WebUI.Models
{
    // Eve gidince LoginViewModel bakılacak username göre yazılacak
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}