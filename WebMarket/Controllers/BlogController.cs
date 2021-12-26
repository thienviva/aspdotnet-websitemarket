using Microsoft.AspNetCore.Mvc;

namespace WebMarket.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
