using JuanProject.DAL;
using JuanProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JuanProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            BlogDetailVM blogDetailVM = new()
            {
                Blog = _context.Blogs
                .Include(b=>b.Comments)
                .FirstOrDefault(b => b.Id == id),
                Blogs = _context.Blogs.OrderBy(b => b.Id).Take(2).ToList()
            };
            return View(blogDetailVM);
        }
    }
}
