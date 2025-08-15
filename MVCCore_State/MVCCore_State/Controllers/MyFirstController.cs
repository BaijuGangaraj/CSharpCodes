using Microsoft.AspNetCore.Mvc;

namespace MVCCore_State.Controllers
{
    public class MyFirstController : Controller
    {
        public IActionResult Index()
        {
            ViewData["MyCityName"] = "Mumbai and chennai";
            ViewBag.Mycountry = "India";

            TempData["myAddress"] = "New Friends colony";
            return RedirectToAction("Index1", "MySecond");
        }
    }
}
