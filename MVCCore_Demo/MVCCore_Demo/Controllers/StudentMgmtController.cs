using Microsoft.AspNetCore.Mvc;
using MVCCore_Demo.Models;

namespace MVCCore_Demo.Controllers
{
    public class StudentMgmtController : Controller
    {
        Student obj = new Student();//global at Class level
        public IActionResult Index()
        {
            List<Student> lst = obj.GetStudentDetails();
            return View(lst);
        }

        public IActionResult RegisterStudent()
        {
            return View();
        }
    }
}
