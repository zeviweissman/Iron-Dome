using iron_dome.Dto;
using iron_dome.Service;
using Microsoft.AspNetCore.Mvc;

namespace iron_dome.Controllers
{
    public class ThreatManagmentController(AdminDto adminDto, IThreatManagmentService threatManagment) : Controller
    {

        public IActionResult Index()
        {
            return View(adminDto);
        }

        public IActionResult AddThreat()
        {
            return View();
        }


        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult AddThreat(ThreatManagmentModel model)
        {
            threatManagment.AddThreat(model);
            return RedirectToAction("Index");

        }


        
        public IActionResult DeleteThreat(long id)
        {
            

            threatManagment.DeleteThreat(id);
            return RedirectToAction("Index");

        }
        
        public IActionResult Launch(long id)
        {
            
            threatManagment.LaunchThreat(id);           
            return RedirectToAction("Index");

        }

    }
}
