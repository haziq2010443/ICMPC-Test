using Microsoft.AspNetCore.Mvc;
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
            if (product == null || product.ProductId == 0)
            {
                return Json(new { success = false, message = "Invalid product data" });
            }

            var existingProduct = await _context.Products.FindAsync(product.ProductId);
            if (existingProduct == null)
            {
                return Json(new { success = false, message = "Product not found" });
            }

            // Update the existing product instead of passing a new object
            existingProduct.ProductName = product.ProductName;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;

            try
            {
                await _context.SaveChangesAsync();
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
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
