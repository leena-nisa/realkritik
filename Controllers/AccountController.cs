using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class AccountController : Controller
    {
        private readonly MvcMovieContext _context;

        // Inject the DbContext (assuming you have it configured)
        public AccountController(MvcMovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new ReviewIndex
            {
                Reviews = _context.Reviews.ToList(),  
                NewReview = new Review()  
            };
            return View(viewModel);
        }
        
        // Action to handle form submission and add a new review
        [HttpPost]
       public async Task<IActionResult> Create(Review review)
        {
            Console.WriteLine(review);
            if (ModelState.IsValid)
            {
                await _context.Reviews.AddAsync(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(review); // Return the view with the review object (pre-populated with user input)
        }
    }
}
