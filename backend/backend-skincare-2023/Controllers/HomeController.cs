using backend_skincare_2023.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace backend_skincare_2023.Controllers
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
            _logger.LogInformation("Main page");
            return View();
        }


        [Authorize]
        public IActionResult Questionario()
        {
            
            return View(); 
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [Route("Home/tipopele")]
        public IActionResult TipoPele()
        {
            // Ação para uma página personalizada
            return View();
        }


        [Route("Home/ativos")]
        public IActionResult Ativos()
        {
            
            return View();
        }


        [Route("Home/masculina")]
        public IActionResult Masculina()
        {
            return View();
        }



        [Route("Home/quemsomos")]
        public IActionResult QuemSomos()
        {
            
            return View();
        }


        [Route("Home/guiapele")]
        public IActionResult GuiaPele()
        {

            return View();
        }


        [Route("Home/privacidade")]
        public IActionResult Privacidade()
        {

            return View();
        }



        [Route("Home/hidratada")]
        public IActionResult Hidratada()
        {

            return View();
        }

        [Route("Home/madura")]
        public IActionResult Madura()
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