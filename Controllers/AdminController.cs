using Banking_Digital_Onboarding.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using System.Linq;

namespace Banking_Digital_Onboarding.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var allApplications = Repository.Applications;
            return View(allApplications);
        }

        public IActionResult Details(int id)
        {
            var application = Repository.Applications.FirstOrDefault(a => a.Id == id);

            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }
    }
}