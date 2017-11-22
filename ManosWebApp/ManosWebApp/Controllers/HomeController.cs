using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ManosWebApp.Models;

namespace ManosWebApp.Controllers
{
    public class HomeController : BaseController
    {
        [Route("")]
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel();

            homeViewModel.IsMobileBrowser = this.IsMobileBrowser;

            return View(model: homeViewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
