using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.Diagnostics;

namespace backend_skincare_2023.Controllers
{
    public class StaticPagesController : Controller
    {

        private readonly ILogger<StaticPagesController> _logger;

        public StaticPagesController(ILogger<StaticPagesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
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
