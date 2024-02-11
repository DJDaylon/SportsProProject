using Microsoft.AspNetCore.Mvc;

namespace SportsProProject.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
