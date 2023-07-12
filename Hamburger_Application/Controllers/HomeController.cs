using Hamburger_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hamburger_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }
    }
}