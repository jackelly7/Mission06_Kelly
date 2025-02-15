using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Kelly.Models;

namespace Mission06_Kelly.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;
    
    private MoviesContext _context;

    public HomeController(MoviesContext temp) // constructor
    {
        _context = temp;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Joel()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AddMovie()
    {
        return View();
    }

    [HttpPost]

    public IActionResult AddMovie(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
        
        return View("AddMovie", movie);
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