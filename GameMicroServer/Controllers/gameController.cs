using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Net;

namespace Micro
{
    public class gameController : Controller
    {
        [HttpGet("games/{id}")]
        public IActionResult GetGame(int id)
        {
            switch (id)
            {
                case 1:
                    return NotFound();
                case 2:
                    return RedirectToAction("GetTetris", "Tetris");
                default:
                    return NotFound();
            }
        }
    }
}