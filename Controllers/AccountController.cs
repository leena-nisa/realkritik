using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    /// <summary>
    /// Module Name: AccountController
    /// Date of Code: 11/1/2024
    /// Programmer's Name: 
    /// 
    /// Description:
    /// Handles user account functionalities such as displaying reviews and allowing users to add new reviews.
    /// Controller for managing user accounts and their associated reviews.
    /// 
    /// Functions:
    /// - Index(): Displays a list of user reviews and a form for adding new reviews.
    /// - Create(Review review): Handles form submissions to add a new review.
    /// 
    /// Important Data Structures:
    /// - Review: Represents a single review submitted by the user.
    /// - ReviewIndex: ViewModel combining existing reviews and a new review form.
    /// 
    /// Algorithms:
    /// A straightforward approach using Entity Framework to query the database and save new reviews.
    /// </summary>
    
    public class AccountController : Controller
    {
        /// <summary>
        /// Database context for interacting with the Reviews table.
        /// </summary>
        private readonly MvcMovieContext _context;
        
        /// <summary>
        /// Initializes a new instance of the AccountController class with a specified database context. Inject the DbContext (assuming you have it configured).
        /// </summary>
        public AccountController(MvcMovieContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Displays the main account page with a list of all reviews and a form for adding a new review.
        /// </summary>

        public IActionResult Index()
        {
            var viewModel = new ReviewIndex
            {
                Reviews = _context.Reviews.ToList(),  
                NewReview = new Review()  
            };
            return View(viewModel);
        }
        
        /// <summary>
        /// Handles form submissions for creating a new review.
        /// Validates the review input.
        /// Adds the review to the database if the input is valid.
        /// </summary>
        /// <returns>
        /// A redirect to the Index action on successful creation or the form view with validation errors.
        /// </returns>
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
