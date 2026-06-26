using System.ComponentModel.DataAnnotations;

namespace _19_Login_Authentication_System.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Enter Valid username.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage ="Enter valid Password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }=string.Empty;
    }
}
