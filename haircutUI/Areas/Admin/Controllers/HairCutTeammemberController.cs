﻿using businesslayers.Interfaces;
using entitylayers;
using haircutUI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace haircutUI.Areas.Admin.Controllers
{
    public class HairCutTeammemberController : Controller
    {
        private readonly IHairCutTeammemberService _service;

        public HairCutTeammemberController(IHairCutTeammemberService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var team = await _service.GetAllAsync();
            var model = team.Select(f => new HairCutTeammemberViewModel
            {
                Id = f.Id,
                Name = f.Name,
                Position = f.Position,
                Bio = f.Bio,
                ImagePath = f.ImagePath



            }).ToList();
            return View(model);
        }

        public IActionResult Create()
        {

            return PartialView("_Create", new HairCutTeammemberViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(HairCutTeammemberViewModel vm)
        {
            if (!ModelState.IsValid) PartialView("_Create", vm);

            var team = new HairCutTeammember
            {
                Name = vm.Name,
                Position = vm.Position,
                Bio = vm.Bio,
                ImagePath = vm.ImagePath
            };
            await _service.AddAsync(team);
            TempData["NotificationMessage"] = "New Worker Add successfully!";

            return Json(new { success = true });

        }

        public async Task<IActionResult> Edit(int id)
        {
            var team = await _service.GetByIdAsync(id);
            if (team == null) return NotFound();
            var vm = new HairCutTeammemberViewModel
            {
                Id = id,
                Name = team.Name,
                Position = team.Position,
                Bio = team.Bio,
                ImagePath = team.ImagePath


            };
            return PartialView("_Edit", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(HairCutTeammemberViewModel vm)
        {
            if (!ModelState.IsValid) return PartialView("_Edit", vm);
            var team = await _service.GetByIdAsync(vm.Id);
            if (team == null) return NotFound();
            team.Name = vm.Name;
            team.Position = vm.Position;
            team.Bio = vm.Bio;
            team.ImagePath = vm.ImagePath;
            await _service.UpdateAsync(team);
            TempData["NotificationMessage"] = "Worker Details Edit successfully!";
            return Json(new { success = true });
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _service.SoftDeleteAsync(id);
            TempData["NotificationMessage"] = "Worker Deleted successfully!";
            return Json(new { success = true });
        }
    }
}
