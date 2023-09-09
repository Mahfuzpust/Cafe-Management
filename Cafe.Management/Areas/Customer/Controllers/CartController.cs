using Microsoft.AspNetCore.Mvc;

namespace Cafe.Management.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
