using iron_dome.Dto;
using iron_dome.Models;
using iron_dome.Service;
using Microsoft.AspNetCore.Mvc;

namespace iron_dome.Controllers
{
    public class AdminController(IAdminService adminService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewBag.Amount = await adminService.GetMissileAmount();
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int missileAmount)
        {
            try
            {
                await adminService.UpdateMissileAmount(missileAmount);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
