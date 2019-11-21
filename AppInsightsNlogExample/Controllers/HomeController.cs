using AppInsightsNlogExample.Models;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Diagnostics;

namespace AppInsightsNlogExample.Controllers
{
    public class HomeController : Controller
    {
        readonly Logger logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

        public IActionResult Index()
        {
            logger.Trace("HomeControler.Index");
            return View();
        }

        public IActionResult Privacy()
        {
            logger.Trace("HomeControler.Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
