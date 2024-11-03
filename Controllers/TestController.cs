using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class TestController : Controller
    {
        private readonly MvcMovieContext _context;

        // Inject the DbContext (assuming you have it configured)
        public TestController(MvcMovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new ReviewIndex
            {
                Reviews = _context.Reviews.ToList(),  // Fetch all reviews from the database
                NewReview = new Review()  // Initialize a new Review object for the form
            };
            return View(viewModel);
        }


        // Action to handle form submission and add a new review
        [HttpPost]
        // [ValidateAntiForgeryToken]
       public async Task<IActionResult> Create(Review review)
        {
            Console.WriteLine(review);
            if (ModelState.IsValid)
            {
                await _context.Reviews.AddAsync(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(review); // Return the view with the review object (pre-populated with user input) for validation errors
        }
    }
}
