using Microsoft.AspNetCore.Mvc;

namespace JuanProject.Areas.AdminAreas.Controllers
{
    [Area("AdminAreas")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
