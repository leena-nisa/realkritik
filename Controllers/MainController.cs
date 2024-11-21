using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class MainController : Controller
{
    private readonly ILogger<MainController> _logger;

    public MainController(ILogger<MainController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}
