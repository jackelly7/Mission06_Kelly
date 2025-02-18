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
        
        return View("Confirmation", movie);
    }
}