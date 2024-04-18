using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace GameMicroServer.Controllers.Games
{
    [ApiController]
    [Route("[controller]")]
    public class TetrisController : Controller
    {
        [HttpGet("Games/Play/2")]
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
