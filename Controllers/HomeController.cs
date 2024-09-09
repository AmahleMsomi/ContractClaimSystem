using ContractClaimSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContractClaimSystem.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Submit()
        {
            return View();
        }

        public IActionResult ViewClaims()
        {
            return View();
        }

        public IActionResult Claims()
        {
            return View();
        }

        public IActionResult ApproversView()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
