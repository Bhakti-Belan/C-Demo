using Microsoft.AspNetCore.Mvc;

namespace TemplateDemo.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SetName()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult SetName(string name)
        {
            HttpContext.Session.SetString("UserName",name);
            return RedirectToAction("GetName");
        }
        public IActionResult GetName()
        {
            var Username=HttpContext.Session.GetString("UserName");
            ViewBag.user = Username ?? "Guest";
            return View();
        }
    }
}
