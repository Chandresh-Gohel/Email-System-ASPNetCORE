using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOT_NET_Core_Email_System.Controllers
{
    public class SidebarController : Controller
    {
        public IActionResult Inbox()
        {
            return View();
        }

        public IActionResult Starred()
        {
            return View();
        }

        public IActionResult Sent()
        {
            return View();
        }

        public IActionResult Trash()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
