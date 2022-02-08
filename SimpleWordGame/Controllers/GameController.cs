using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleWordGame.Model;

namespace SimpleWordGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private static Game _game;

        [HttpPost]
        public Game StartGame()
        {
            _game = new Game("Hemmelig");
            return _game;
        }

        [HttpPut]
        public Game Guess(Guess guess)
        {
            _game.Guess(guess.Letter);
            return _game;
        }


        // GET api/<GameController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
    }
}
