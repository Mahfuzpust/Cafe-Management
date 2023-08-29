using Cafe.DataAccess.Data;
using Cafe.Models;
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
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        //Edit GET Method
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category category = _db.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //Edit POST Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
                TempData["success"] = "Category Edited Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        //Delete GET Method
        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            Category category = _db.Categories.FirstOrDefault(u => u.Id == id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //Delete POST Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[ActionName("Delete")]
        public IActionResult Delete(int? id, Category category)
        {
            if(ModelState.IsValid)
            {
                _db.Categories.Remove(category);
                _db.SaveChanges();
                TempData["success"] = "Category Deleted Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
    }
}
