using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
{
    public class LoginAndRegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
