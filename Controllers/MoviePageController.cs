using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class MoviePageController : Controller
{
    private readonly ILogger<MoviePageController> _logger;

    public MoviePageController(ILogger<MoviePageController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}
