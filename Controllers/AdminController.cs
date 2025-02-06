using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
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

        public IActionResult Dashboard()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
