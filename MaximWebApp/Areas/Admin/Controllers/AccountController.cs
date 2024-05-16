using MaximWebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MaximWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Login(AdminLoginVM adminLoginVM)
        {

            return RedirectToAction("Index","Dashboard");
        }
    }
}
