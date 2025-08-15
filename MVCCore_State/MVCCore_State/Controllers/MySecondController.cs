using Microsoft.AspNetCore.Mvc;

namespace MVCCore_State.Controllers
{
    public class MySecondController : Controller
    {
        public IActionResult Index()
        {
            if (TempData["myAddress"] != null)
            {
                string mycollectedData = TempData["myAddress"].ToString();
            }
            else
            {
                string mycollectedData = "No Address found  ";
            }
            return View();
        }
            
    }
}
