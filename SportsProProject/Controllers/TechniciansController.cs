using Microsoft.AspNetCore.Mvc;

namespace SportsProProject.Controllers
{
    public class TechniciansController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
