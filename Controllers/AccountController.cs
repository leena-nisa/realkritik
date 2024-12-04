using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class AccountController : Controller
    {
        private readonly MvcMovieContext _context;

        public AccountController(MvcMovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {   
            var userId = HttpContext.Session.GetInt32("UserId");
            var username = HttpContext.Session.GetString("Username");
            ViewData["UserId"] = userId;
            ViewData["Username"] = username;

            var reviews = _context.Reviews?.ToList() ?? new List<Review>();
            return View(reviews);
        }

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                TempData["Error"] = "Invalid login. Please provide both username and password.";
                return RedirectToAction("Index", "Home");
            }

            var user = _context.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);

            if (user == null)
            {
                TempData["Error"] = "Invalid login. Username or password is incorrect.";
                return RedirectToAction("Index", "Home");
            }

            HttpContext.Session.SetInt32("UserId", user.Id);
            HttpContext.Session.SetString("Username", user.Username);

            TempData["Success"] = "Login successful.";
            return RedirectToAction("Index", "Account");
        }


        [HttpPost]
        public async Task<IActionResult> SignUp(User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _context.Users.FirstOrDefault(u => u.Username == user.Username);
                if (existingUser != null)
                {
                    TempData["Error"] = "Signup failed. Username already exists.";
                    return RedirectToAction("Index", "Home");
                }

                _context.Users.Add(user);
                await _context.SaveChangesAsync(); // Save the new user to the database

                TempData["Success"] = "Signup successful! Please log in.";
                return RedirectToAction("Index", "Home");
            }

            TempData["Error"] = "Signup failed. Please check your input.";
            return RedirectToAction("Index", "Home");
        }

    }
}