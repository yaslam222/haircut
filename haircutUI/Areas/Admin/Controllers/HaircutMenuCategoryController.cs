using businesslayers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace haircutUI.Areas.Admin.Controllers
{
    public class HaircutMenuCategoryController : Controller
    {
        private readonly IHaircutMenuCategoryService _menuCategoryService;

        public HaircutMenuCategoryController(IHaircutMenuCategoryService menuCategoryService)
        {
            _menuCategoryService = menuCategoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _menuCategoryService.GetAllAsync();
            return View(categories);
        }

        public async Task<IActionResult> Details(int id)
        {
            var category = await _menuCategoryService.GetByIdAsync(id);
            if (category == null) return NotFound();

            return View(category);
        }
    }
}
