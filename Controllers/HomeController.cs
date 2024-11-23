using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;
    /// <summary>
    /// Module Name: HomeController
    /// Date of Code: 10/28/2024
    /// Programmer's Name:
    /// 
    /// Description:
    /// Handles requests for the home page, privacy page, and error handling within the application.
    /// 
    /// Functions:
    /// - Index(): Displays the home page.
    /// - Privacy(): Displays the privacy policy page.
    /// - Error(): Displays the error page with a detailed error log.
    /// 
    /// Important Data Structures:
    /// - ErrorViewModel: Contains details about the error, such as RequestId.
    /// 
    /// Algorithms:
    /// Basic routing and error handling are implemented.
    /// </summary>
public class HomeController : Controller
{
    /// <summary>
    /// Logger instance for logging application events and errors.
    /// </summary>
    private readonly ILogger<HomeController> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="HomeController"/> class.
    /// </summary>
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Displays the home page of the application.
    /// </summary>
    public IActionResult Index()
    {
        return View();
    }

    /// <summary>
    /// Displays the privacy policy page of the application.
    /// </summary>
    public IActionResult Privacy(){
        return View(); 
    }

    /// <summary>
    /// Displays the error page for the application.
    /// </summary>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}