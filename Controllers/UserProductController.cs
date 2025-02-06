using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ICMPC_Test.Data;
using ICMPC_Test.Models;

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

        //Get Product By Id
        [HttpGet]
        public async Task<IActionResult> ProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                return NotFound();
            }

            return Json(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            if (product == null)
            {
                return Json(new { success = false, message = "Invalid data" });
            }

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                return Json(new { success = false, message = "User not authenticated" });
            }

            product.UserId = int.Parse(userId);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }

        //Edit existing product
        [HttpPost]
        public async Task<IActionResult> Edit([FromBody] Product product)
        {
            if (product == null)
            {
                return Json(new { success = false, message = "Invalid data" });
            }

            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }

        //Delete Product from DB
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return Json(new { success = false, message = "Product Not Found" });
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }
    }
}
