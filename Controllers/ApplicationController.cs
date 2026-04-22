using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;

namespace Banking_Digital_Onboarding.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Apply()
        {
            return View();
        }
    }
}