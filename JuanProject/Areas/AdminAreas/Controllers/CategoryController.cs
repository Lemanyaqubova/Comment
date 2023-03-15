using JuanProject.DAL;
using JuanProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace JuanProject.Areas.AdminAreas.Controllers
{

    [Area("AdminAreas")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CategoryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View(_appDbContext.Categories.ToList());
        }
        public IActionResult Detail(int id)
        {
            if (id == null) return NotFound();
            Category category = _appDbContext.Categories.SingleOrDefault(c => c.Id == id);
            if(category == null) return NotFound();
            return View(category);

        }
    }
}
