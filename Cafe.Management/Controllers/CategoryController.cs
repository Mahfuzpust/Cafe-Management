using Microsoft.AspNetCore.Mvc;

namespace Cafe.Management.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
