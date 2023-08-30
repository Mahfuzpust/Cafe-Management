using Cafe.DataAccess.Data;
using Cafe.DataAccess.Repository.IRepository;
using Cafe.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.Management.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryController(ICategoryRepository db)
        {
            _categoryRepo = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _categoryRepo.GetAll().ToList();
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
                _categoryRepo.Add(category);
                _categoryRepo.Save();
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
            Category category = _categoryRepo.Get(c => c.Id == id);
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
                _categoryRepo.Update(category);
                _categoryRepo.Save();
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
            Category category = _categoryRepo.Get(u => u.Id == id);
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
                _categoryRepo.Remove(category);
                _categoryRepo.Save();
                TempData["success"] = "Category Deleted Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
    }
}
