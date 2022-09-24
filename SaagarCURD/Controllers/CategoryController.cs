using Microsoft.AspNetCore.Mvc;
using SaagarCURD.Data;
using SaagarCURD.Models;
using System.Collections.Generic;

namespace SaagarCURD.Controllers
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

            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);

        }
    }
}
