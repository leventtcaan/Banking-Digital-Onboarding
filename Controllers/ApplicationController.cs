using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;
using Banking_Digital_Onboarding.Models;

namespace Banking_Digital_Onboarding.Controllers
{
    
    public class ApplicationController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(CustomerApplication model)
        {
            TempData["SuccessMessage"] = $"Sayın {model.FullName}, {model.ApplicationType} başvurunuz başarıyla alındı! ";

            return RedirectToAction("Apply");
        }


    }
}