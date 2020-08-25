using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCClient.Models;
using Newtonsoft.Json.Linq;

namespace MVCClient.Controllers
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

        public async Task<IActionResult> TestAuthApi()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            
            var response = await client.GetAsync("https://localhost:5101/api1");
            ViewBag.Api1ScopeResponse = response.StatusCode;

            response = await client.GetAsync("https://localhost:5101/api2");
            ViewBag.Api2ScopeResponse = response.StatusCode;

            response = await client.GetAsync("https://localhost:5101/groot");
            ViewBag.GrootScopeResponse = response.StatusCode;

            return View();
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

        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }

        public IActionResult Alice()
        {
            return SignOut("Cookies", "oidc");
        }

        public IActionResult Bob()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}
