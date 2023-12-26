using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JobBoardApp.Models;
using JobBoardApp.Data;

namespace JobBoardApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly JobBoardContext _context;

    public HomeController(ILogger<HomeController> logger, JobBoardContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var Categories = _context.Categories;
        return View(Categories);
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
