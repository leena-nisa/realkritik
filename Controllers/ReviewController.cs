using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class ReviewController : Controller
    {
        private readonly MvcMovieContext _context;

        public ReviewController(MvcMovieContext context)
        {
            _context = context;
        }

        public IActionResult Create(int Score, string ReviewDescription, string status, string Title, int UserId)
        {
            var review = new Review
            {
                Title = Title,
                status = status,
                Score = Score,
                ReviewDescription = ReviewDescription,
                UserId = UserId 
            };

            _context.Reviews.Add(review);
            _context.SaveChanges();



            return View("Index", "Account");
        }


    }

}