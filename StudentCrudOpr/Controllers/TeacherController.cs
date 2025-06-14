using Microsoft.AspNetCore.Mvc;

namespace StudentCrudOpr.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddTeacher()
        {
            ViewBag.Message = "Add Teacher Page";
            return View();
        }

        public IActionResult UpdateTeacher()
        {
            ViewBag.Message = "Update Teacher Page";
            return View();
        }

        public IActionResult DeleteTeacher()
        {
            ViewBag.Message = "Delete Teacher Page";
            return View();
        }

        public IActionResult DisplayTeacher()
        {
            ViewBag.Message = "Display Teacher Page";
            return View();
        }
    }
}
