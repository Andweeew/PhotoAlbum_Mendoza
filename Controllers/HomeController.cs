using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhotoGallery.Models;

namespace PhotoGallery.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Page1()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Page2()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Page3()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Page4()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Page5()
    {
        return View();
    }

}
