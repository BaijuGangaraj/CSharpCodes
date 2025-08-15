using Microsoft.AspNetCore.Mvc;

namespace MVCCore_RazorSyntax.Controllers
{
    public class RazorExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
