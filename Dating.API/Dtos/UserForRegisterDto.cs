using System.ComponentModel.DataAnnotations;

namespace Dating.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength=6, ErrorMessage="You must enter a password between 6 and 8 chacters")]
        public string Password { get; set; }
    }
}