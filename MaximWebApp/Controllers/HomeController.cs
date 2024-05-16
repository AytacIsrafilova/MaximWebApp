
using MaximWebApp.DAL;
using MaximWebApp.Models;
using MaximWebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaximWebApp.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;

		public HomeController(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index()
        {
            Slider slider1 = new Slider()
            {
                Title="Nese o doyul",
                MainImg= "img/logo-image.png"

			};
            Slider slider2 = new Slider()
            {
                Title="Yasayis yoxdu",
                MainImg= "img/logo-image.png"
			};
            List<Slider> sliders = new List<Slider>();
            sliders.Add(slider1);
            sliders.Add(slider2);

            Servicee servicee1 = new Servicee()
            {
                Name="Design",
                Description="cjsjbjbvdjbv",
                ImgUrl= "img/icons/laptop.png"
			};

			Servicee servicee2 = new Servicee()
			{
				Name = "Development",
				Description = "shdjkbvsjkj",
				ImgUrl = "img/icons/lab.png"
			};
			Servicee servicee3 = new Servicee()
			{
				Name = "Photo",
				Description = "ehfhigfbanker",
				ImgUrl = "img/icons/camera.png"
			};
			Servicee servicee4 = new Servicee()
			{
				Name = "Eco",
				Description = "knckbjdbajv",
				ImgUrl = "img/icons/basket.png"
			};
			List<Servicee> servicees = new List<Servicee>();
            servicees.Add(servicee1);
            servicees.Add(servicee2);
            servicees.Add(servicee3);
            servicees.Add(servicee4);

            HomeVM homeVM = new HomeVM()
            {
                Servicees = servicees,
                Sliders=sliders,
            };


            return View(homeVM);
        }

        
    }
}
