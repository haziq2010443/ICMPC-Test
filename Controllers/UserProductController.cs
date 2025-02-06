using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ICMPC_Test.Data;

namespace ICMPC_Test.Controllers
{
    public class UserProductController : Controller
    {
        private readonly UserProductsContext _context;

        public UserProductController(UserProductsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1, int pageSize = 10)
        {
            //Get logged-in user id 
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                //Return to login page if credential does not match any data
                return RedirectToAction("Login", "Account");
            }

            var products = await _context.Products
                .Where(p => p.UserId.ToString() == userId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return View("~/Views/Admin/Dashboard.cshtml", products);
        }
    }
}
