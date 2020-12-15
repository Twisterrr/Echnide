using System.ComponentModel.DataAnnotations;

namespace EchnideApp.Models
{
    public class RegisterModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [Required(ErrorMessage = "T'as pas miston email")]
        public string Email     { get; set; }
        public string ConfirmedEmail { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
    }
}