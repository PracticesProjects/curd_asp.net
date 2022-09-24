using Microsoft.AspNetCore.Mvc;

namespace SaagarCURD.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
