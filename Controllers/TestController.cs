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
        [ValidateAntiForgeryToken]
        public IActionResult Create(Review review)
        {
            if (ModelState.IsValid)
            {
                _context.Reviews.Add(review); // Add review to the DbContext
                _context.SaveChanges(); // Save changes to the database
                return RedirectToAction(nameof(Index)); // Redirect back to the list view
            }
            return View(review);
        }
    }
}
