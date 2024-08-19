using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    //Field (class variable)
    private readonly ILogger<HomeController> _logger;

    //Constructor
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //Method
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Cruz()
    {
        return View();
    }
    
    //Method
    public IActionResult Privacy()
    {
        return View();
    }

    //Method
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}