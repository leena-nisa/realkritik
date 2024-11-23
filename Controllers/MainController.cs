using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;
    /// <summary>
    /// Module Name: MainController
    /// 
    /// Date of Code: 10/28/2024
    /// Programmer's Name: 
    /// 
    /// Description:
    /// Manages the main entry point for the application, such as the dashboard or profile page.
    /// 
    /// Functions:
    /// - Index(): Displays the main page.
    /// 
    /// Important Data Structures:
    /// None explicitly used in this version of the controller.
    /// 
    /// Algorithms:
    /// Simple routing is used to serve a static view. No additional logic or algorithms are implemented.
    /// </summary>
public class MainController : Controller
{
    private readonly ILogger<MainController> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainController"/> class.
    ///</summary>
    public MainController(ILogger<MainController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Displays the main page of the application.
    /// </summary>
    public IActionResult Index()
    {
        return View();
    }

}
