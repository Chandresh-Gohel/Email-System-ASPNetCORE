using DOT_NET_Core_Email_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DOT_NET_Core_Email_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<IdentityUser> _manager;

        public HomeController(ILogger<HomeController> logger, SignInManager<IdentityUser> manager)
        {
            _logger = logger;
            _manager = manager;
        }

        public IActionResult Index()
        {
            if (_manager.IsSignedIn(User))
            {
                Response.Redirect("/Sidebar/Inbox");
            }
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
    }
}
