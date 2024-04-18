using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Net;
using System; // Add this to use Console.WriteLine

namespace Micro
{
    [ApiController]
    [Route("[controller]")]
    public class gameController : Controller
    {
        [HttpGet("Games/Play/{id}")]
        public IActionResult GetGame(int id)
        {
            switch (id)
            {
                case 1:
                    return NotFound();
                case 2:
                    Console.WriteLine("Redirecting to TetrisController");
                    return RedirectToAction("GetTetris", "Tetris");
                default:
                    return NotFound();
            }
        }
    }
}