using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChessGalery.Models;

namespace ChessGalery.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    
}
