using Microsoft.AspNetCore.Mvc;

namespace SportsProProject.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
