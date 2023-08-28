using Cafe.Management.Data;
using Cafe.Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.Management.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        //Create GET Method
        public IActionResult Create()
        {
            return View();
        }

        //Crete POST Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
    }
}
