using _19_Login_Authentication_System.Models;

namespace _19_Login_Authentication_System.Services
{
    public interface IAccountService
    {
        //true → Registration सफल। false → Registration असफल।
        Task<bool> RegisterAsync(RegisterViewModel model);
        //true यदि Login सफल।
        Task<bool> LoginAsync(LoginViewModel model);

        //Authentication Cookie Delete की जाती है।
        Task LogoutAsync();

        // Database में Check करता है कि Email पहले से मौजूद है या नहीं।
        Task<bool> EmailExistsAsync(string email);
    }
}
