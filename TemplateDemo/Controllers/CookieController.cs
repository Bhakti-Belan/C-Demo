using Microsoft.AspNetCore.Mvc;

namespace TemplateDemo.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SetCookie()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(30);
            Response.Cookies.Append("UserName", "Bhakti Belan", options);
            return Content("Cookie Has Been Set!");
        
        }
        public IActionResult GetCookie()
        {
            String userName = Request.Cookies["UserName"] ?? "Guest";
            return Content($"Hello,{userName}!");


        }
        public IActionResult DeleteCookie()
        {
            Response.Cookies.Delete("UserName");
            return Content("Cookie Has Been Deleted");
        }
    }
}
