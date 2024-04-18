using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace GameMicroServer.Controllers.Games
{
    public class TetrisController : Controller
    {
        [HttpGet("tetris")]
        public IActionResult GetTetris()
        {
            string relativePath = Path.Combine("GamesJs", "tetris.js");
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), relativePath);
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }
            string fileContents = System.IO.File.ReadAllText(filePath);
            return Content(fileContents, "application/javascript");
        }
    }
}
