using _19_Login_Authentication_System.Models;
using _19_Login_Authentication_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace _19_Login_Authentication_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService= accountService;
        }

        // GET : Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //POST : Register
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if(await _accountService.EmailExistsAsync(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "Email already exists.");
                return View(model);
            }
            bool result = await _accountService.RegisterAsync(model);

            if (result)
                return RedirectToAction("Login");
            ModelState.AddModelError("", "Registration Failed.");
            return View(model);
        }

        // GET : Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST : Login
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            bool result= await _accountService.LoginAsync(model);

            if (result)
                return RedirectToAction("Index", "Home");
            ModelState.AddModelError("", "Invalid username or password.");
            return View(model);
        }

        // Logout
        public async Task<IActionResult> Logout()
        {
            await _accountService.LogoutAsync();
            return RedirectToAction("Login");
        }
    }
}
