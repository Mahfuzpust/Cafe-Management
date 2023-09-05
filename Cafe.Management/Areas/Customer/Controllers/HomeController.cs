using Cafe.DataAccess.Repository.IRepository;
using Cafe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cafe.Management.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        //Product pass in Home page
        public IActionResult Index()
        {
            IEnumerable<Product> productlist = _unitOfWork.Product.GetAll(includeProperties: "Category");
            return View(productlist);
        }

        //Details Page
        public IActionResult Details(int productId)
        {
            Product product = _unitOfWork.Product.Get(u=>u.Id == productId, includeProperties: "Category");
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}