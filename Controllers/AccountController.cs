using Microsoft.AspNetCore.Mvc;
using ICMPC_Test.Models;
using ICMPC_Test.Data;

namespace ICMPC_Test.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserProductsContext _context;

        public AccountController(UserProductsContext context)
        {
            _context = context;
        }
        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if(user == null | !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                ViewBag.Error = "Invalid email or password.";
                return View();
            }

            HttpContext.Session.SetString("UserId", user.UserId.ToString());
            HttpContext.Session.SetString("Username", user.UserName);
            HttpContext.Session.SetString("LastActivity", DateTime.UtcNow.ToString());

            return RedirectToAction("Index", "UserProduct");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user, string password)
        {
            if(_context.Users.Any(u => u.Email == user.Email))
            {
                ViewBag.Error = "Email already in use";
                return View();
            }

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToAction("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
