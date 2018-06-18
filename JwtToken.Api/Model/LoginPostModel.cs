using JwtToken.Api.Validators;
using System.ComponentModel.DataAnnotations;

namespace JwtToken.Api.Model
{
    public class LoginPostModel
    {
        [Required]
        [StringEquals("bob")]
        public string Username { get; set; }

        [Required]
        [StringEquals("asd123")]
        public string Password { get; set; }
    }
}
