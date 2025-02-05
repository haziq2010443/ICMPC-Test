using Microsoft.AspNetCore.Mvc;

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
