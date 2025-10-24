using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TranHoangViet_231230961_de01.Models;

namespace TranHoangViet_231230961_de01.Controllers
{
    public class thvHomeController : Controller
    {
        private readonly ILogger<thvHomeController> _logger;

        public thvHomeController(ILogger<thvHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult thvIndex()
        {
            return View();
        }

        public IActionResult thvPrivacy()
        {
            return View();
        }
        public IActionResult thvContact() { 
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult thvError()
        {
            return View(new thvErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
