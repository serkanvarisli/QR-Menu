using Microsoft.AspNetCore.Mvc;
using QR_MENU.Models;
using System.Diagnostics;

namespace QR_MENU.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}