using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimixTeste.Models;

namespace SimixTeste.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string nome)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index()
        {
            var lstString = new List<string>();
            for (int i = 1; i <= 200; i++)
            {
                var ehDivisivelPor3 = (i % 3) == 0;
                var ehDivisivelPor5 = (i % 5) == 0;

                if (ehDivisivelPor3 && ehDivisivelPor5)
                    lstString.Add("Z");
                else if (ehDivisivelPor3)
                    lstString.Add("X");
                else if (ehDivisivelPor5)
                    lstString.Add("Y");
                else
                    lstString.Add(i.ToString());

            }

            return View(lstString);

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
