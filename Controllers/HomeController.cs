using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NguyenDuongHungBTH.Models;

namespace NguyenDuongHungBTH.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(int Age)
    {
        ViewBag.age = "HAHA,già rồi còn chưa có ny =)))";
        return View();
    }
}