using System.ComponentModel.DataAnnotations;

namespace _19_Login_Authentication_System.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="UserName is required.")]
        public string UserName { get; set; }=string.Empty;


        [Required(ErrorMessage ="email is required.")]
        [EmailAddress(ErrorMessage ="Enter valid email address.")]
        public string Email { get; set; } = string.Empty;


        [Required(ErrorMessage ="Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;


        [Required(ErrorMessage ="Confirm password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Passwords do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}   
