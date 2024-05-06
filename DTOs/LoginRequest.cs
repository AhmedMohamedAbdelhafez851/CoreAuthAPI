using System.ComponentModel.DataAnnotations;

namespace ApisToFlutter.DTOs
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "please enter user name  ")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "please enter user Password ")]
        public string? Password { get; set; }
    }
}
