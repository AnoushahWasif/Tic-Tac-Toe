using Microsoft.AspNetCore.Mvc;
using TicTacToe.Model;
using TicTacToeAPI.Services;

namespace TicTacToeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameService _gameService;

        public GameController()
        {
            _gameService = new GameService();
        }

        [HttpGet("state")]
        public ActionResult<GameState> GetGameState()
        {
            return _gameService.GetGameState();
        }

        [HttpPost("move")]
        public ActionResult<GameState> MakeMove([FromBody] Move move)
        {
            return _gameService.MakeMove(move);
        }
    }
}
