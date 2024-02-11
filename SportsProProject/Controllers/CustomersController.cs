using Microsoft.AspNetCore.Mvc;

namespace SportsProProject.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
