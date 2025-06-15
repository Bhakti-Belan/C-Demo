using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentCrudOpr.Models;

namespace StudentCrudOpr.Controllers
{
   public class UserController : Controller
    {
   /*     private readonly AppDBContext _context;

        public UserController(AppDBContext context)
        {
            _context = context;
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User_UserProfile vm)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = vm.UserName
                };

                var userProfile = new UserProfile
                {
                    Bio = vm.Bio,
                    user = user
                };

                user.Profile = userProfile;

                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // or wherever you want
            }
            return View(vm);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var user = await _context.Users
                .Include(u => u.Profile)
                .FirstOrDefaultAsync(u => u.UserId == id);

            if (user == null) return NotFound();

            var vm = new User_UserProfile
            {
                UserId = user.UserId,
                UserName = user.UserName,
                UserProfileId = user.Profile?.UserProfileId ?? 0,
                Bio = user.Profile?.Bio
            };

            return View(vm);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, User_UserProfile vm)
        {
            if (id != vm.UserId) return NotFound();

            if (ModelState.IsValid)
            {
                var user = await _context.Users
                    .Include(u => u.Profile)
                    .FirstOrDefaultAsync(u => u.UserId == id);

                if (user == null) return NotFound();

                user.UserName = vm.UserName;

                if (user.Profile != null)
                {
                    user.Profile.Bio = vm.Bio;
                }
                else
                {
                    user.Profile = new UserProfile
                    {
                        Bio = vm.Bio,
                        UserId = user.UserId
                    };
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }

        // Optional: List Users
        public async Task<IActionResult> Index()
        {
            var users = await _context.Users.Include(u => u.Profile).ToListAsync();
            return View(users);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.Profile)
                .FirstOrDefaultAsync(m => m.UserId == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.Profile)
                .FirstOrDefaultAsync(m => m.UserId == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }*/


    }
}
