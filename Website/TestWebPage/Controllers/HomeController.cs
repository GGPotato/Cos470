using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestWebPage.Models;

namespace TestWebPage.Controllers
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
            var catNames = new[] { "shadow", "fluffy", "smokey"};
     
            return View(catNames);
        }
        [HttpPost]
        public ActionResult<int> NewCat([FromBody] string catName)
        {
            //var catNames = new[] { "shadow", "fluffy", "smokey" };
            var id = Vet.AddNewCat(catName);
            return ApplicationResult<int>(id);
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
