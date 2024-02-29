using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace Micro
{
    [ApiController]
    [Route("[controller]")]
    public class MicroController : ControllerBase
    {
        private static readonly List<GameInfo> TheInfo = new List<GameInfo>
        {
            new GameInfo { 
                //Id = 1,
                Title = "Snake",
                //Content = "~/js/snake.js",
                Author = "A Team Bobby Project",
                DateAdded = "01/01/1942",
                Description = "Dive into nostalgia with our online version of the iconic Snake game! " +
                              "Control your snake as it slithers around the screen, gobbling up food to grow longer. " +
                              "But beware, hitting the walls or yourself ends the game! " +
                              "Challenge yourself to beat your high score and become the ultimate Snake champion. " +
                              "Enjoy this classic game right in your browser, no downloads required!",
                HowTo = "The goal is to eat food while avoiding collisions with the snake's body and the boundaries. " +
                        "Use the arrow keys and steer the snake to consume food, making it longer. " +
                        "The game ends if the snake collides with itself or the borders.",
                //Thumbnail = "/images/snake.jpg" //640x360 resolution
            },
            new GameInfo { 
                //Id = 2,
                Title = "Tetris",
                //Content = "~/js/tetris.js",
                Author = "A Team Bobby Project",
                DateAdded = "09/09/1541",
                Description = "Experience the thrill of Tetris on our website! Arrange the falling blocks to create solid lines and clear them from the board. " +
                              "Keep up as the blocks fall faster and faster, testing your reflexes and strategic thinking. " +
                              "With its addictive gameplay and timeless appeal, Tetris is a must-play for gamers of all ages. " +
                              "Play now and see how many lines you can clear!",
                HowTo = "Arrange the falling blocks to create complete horizontal lines, which disappear, scoring points. USe the arrow keys: up rotates the blocks, " +
                        "left and right move the blocks across the screen, and down makes them fall faster. " +
                        "As the game progresses, blocks fall faster, challenging players to think and react quickly. " +
                        "The game ends when the blocks reach the top of the playing field.",
                //Thumbnail = "/images/tetris.jpg"
            },
            new GameInfo { 
                //Id = 3,
                Title = "Pong",
                //Content = "~/js/pong.js",
                Author = "A Team Bobby Project",
                DateAdded = "07/04/1742",
                Description = "Get ready for some retro gaming fun with our online version of Pong! Control your paddle and bounce the ball past your opponent to score points. " +
                              "With simple controls and addictive gameplay, Pong is the perfect way to challenge your friends or test your skills solo. " +
                              "Can you outmaneuver your opponent and claim victory? Play now and find out!",
                HowTo = "Control paddles with the arrow keys to hit a ball back and forth across a screen. " +
                        "The goal is to prevent the ball from passing your paddle while trying to score points by getting the ball past your opponent's paddle. " +
                        "The game continues until one player fails to return the ball, at which point the opposing player scores a point.",
                //Thumbnail = "/images/pong.jpg"
            },

        };

        private readonly ILogger<MicroController> _logger;

        public MicroController(ILogger<MicroController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GameInfo> Get()
        {
            return TheInfo;
        }
    }
}
