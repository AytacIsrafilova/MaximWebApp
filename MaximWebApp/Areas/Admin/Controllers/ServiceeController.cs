using MaximWebApp.DAL;
using MaximWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MaximWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceeController : Controller
    {
        AppDbContext _dbContext;

        public ServiceeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Servicee> servicees=_dbContext.Servicees.Include(x=>x.servicees).ToList();
            return View(servicees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Servicee servicee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            _dbContext.Servicees.Add(servicee);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var servicee = _dbContext.Servicees.FirstOrDefault(x => x.Id == id);
            if (servicee == null)
            {
                return RedirectToAction("Index");
            }

            return View(servicee);


        }

        [HttpPost]
        public IActionResult Update(Servicee newServicee)
        {
            var oldServicee = _dbContext.Servicees.FirstOrDefault(x => x.Id == newServicee.Id);
            if (oldServicee == null)
            {
                return RedirectToAction("Index");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            oldServicee.Name = newServicee.Name;
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
