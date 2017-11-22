using Microsoft.AspNetCore.Mvc;
using ManosWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManosWebApp.Controllers
{
    public class TermsController : BaseController
    {
        [Route("terminos")]
        public IActionResult Index()
        {
            var termsViewModel = new TermsViewModel();

            termsViewModel.IsMobileBrowser = this.IsMobileBrowser;

            return View(model: termsViewModel);
        }
    }
}
