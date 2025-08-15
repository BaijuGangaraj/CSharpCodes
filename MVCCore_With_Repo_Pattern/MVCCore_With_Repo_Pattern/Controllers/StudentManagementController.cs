using DL_MVCCore.Abstract;
using DL_MVCCore.Model;
using DL_MVCCore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MVCCore_With_Repo_Pattern.Controllers
{
    public class StudentManagementController : Controller
    {
        IStudentManagementRepository _repo= new StudentManagementRepository();
        public IActionResult Index()
        {
            List<Student> lst = _repo.GetAllStudents();
            return View("~/Views/StudentManagement/Index.cshtml", lst);
        }
    }
}
