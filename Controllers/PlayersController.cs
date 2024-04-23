using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChessGalery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChessGalery.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult List()
        {
            return View(Repository.Players);
        }

        public IActionResult Details(int? id)
        {
            var player = Repository.GetById(id);
            return View(player);
        }

        
    }
}