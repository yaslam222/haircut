using Microsoft.AspNetCore.Mvc;

namespace haircutUI.Areas.Admin.Controllers
{
    public class HaircutServicesCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
