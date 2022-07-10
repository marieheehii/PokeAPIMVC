using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PokeAPIMVC.Models;

namespace PokeAPIMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static Random _random = new Random();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string[] welcomes = new[] {"Hello","Welcome","Hi"}; 
        string welcome = welcomes[_random.Next(0, welcomes.Length)];
        return View(model: welcome);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
