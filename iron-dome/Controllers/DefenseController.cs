using iron_dome.Dto;
using iron_dome.Service;
using Microsoft.AspNetCore.Mvc;

namespace iron_dome.Controllers
{
    public class DefenseController(AdminDto adminDto) : Controller
    {
        public IActionResult Index()
        {
            var activeThreats = adminDto.ActiveThreats
                .Where(threat => threat.IsActive)
                .ToList();
            return View(activeThreats);
        }
    }
}
