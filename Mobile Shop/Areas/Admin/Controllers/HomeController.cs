using Microsoft.AspNetCore.Mvc;

namespace Mobile_Shop.Areas.User.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
