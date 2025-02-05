using Microsoft.AspNetCore.Mvc;
using ICMPC_Test.Data;
using ICMPC_Test.Models;

namespace ICMPC_Test.Controllers
{
    public class UserProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
