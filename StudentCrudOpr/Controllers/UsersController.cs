using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCrudOpr.Models;
using System.Threading.Tasks;

namespace StudentCrudOpr.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDBContext _context;

        public UsersController(AppDBContext context)
        {
            _context = context;
        }
        // GET: UsersController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UsersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsersController/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create1()
        {
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( UserCreateViewModel model)
        {
            UserProfile userprofile = new UserProfile
            {
                FullName = model.FullName,
                Age = model.Age
            };
            var user = new User
            {
                Email = model.Email,
                Password=model.Password,
                Name=model.FullName,
                Profile=userprofile
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: UsersController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View();
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
      /*  public ActionResult Edit(int id, IFormCollection collection)
        {
           
        }*/

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
