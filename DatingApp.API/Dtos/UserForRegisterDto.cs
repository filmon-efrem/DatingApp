using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(16, MinimumLength =4, ErrorMessage="You must specify password between 8 and 16 characters")]
        public string Password { get; set; }
    }
}