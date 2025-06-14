using Microsoft.AspNetCore.Mvc;
using StudentCrudOpr.Models;

namespace StudentCrudOpr.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDBContext _context;
        public StudentController(AppDBContext context)
        {
         _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            ViewBag.Message = "Add Student Page";
            return View();
        }
       [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            _context.Students.Add(student); 
            await _context.SaveChangesAsync();
            return RedirectToAction("AddStudent");
          
        }

        public IActionResult UpdateStudent()
        {
            ViewBag.Message = "Update Student Page";
            return View();
        }

        public IActionResult DeleteStudent()
        {
            ViewBag.Message = "Delete Student Page";
            return View();
        }

        public IActionResult DisplayStudent()
        {
            
            ViewBag.Message = "Display Student Page";
            return View();
        }
    }
}
