using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using ICMPC_Test.Data;
using ICMPC_Test.Models;

namespace ICMPC_Test.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        //Inject DB context
        private readonly UserProductsContext _context;

        public AdminController(UserProductsContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard(int page = 1)
        {
            // Number of items per page
            int pageSize = 5;

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(currentUserId))
            {
                return RedirectToAction("Login", "Account");
            }

            // Fetch products for the current user and current page
            var products = _context.Products
                                    .Where(p => p.UserId.ToString() == currentUserId)
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToList();

            // Calculate number of pages
            var totalProducts = _context.Products.Count(p => p.UserId.ToString() == currentUserId);
            var totalPages = (int)Math.Ceiling((double)totalProducts / pageSize);

            // Return paginated data to the view model
            var model = new PaginatedProductsViewModel
            {
                Products = products,
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View(model);
        }

    }
}
