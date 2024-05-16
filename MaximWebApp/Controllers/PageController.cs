using Microsoft.AspNetCore.Mvc;

namespace MaximWebApp.Controllers
{
	public class PageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
