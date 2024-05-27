using TicTacToe.Model;

namespace TicTacToeAPI.Services
{
    public class GameService
    {
        private readonly GameState _gameState = new GameState();

        public GameState GetGameState()
        {
            return _gameState;
        }

        public GameState MakeMove(Move move)
        {
            if (_gameState.IsGameOver || _gameState.Board[move.X, move.Y] != '\0')
            {
                return _gameState;
            }

            _gameState.Board[move.X, move.Y] = _gameState.CurrentPlayer;
            if (CheckWin(_gameState.CurrentPlayer))
            {
                _gameState.IsGameOver = true;
                _gameState.Winner = _gameState.CurrentPlayer;
            }
            else if (IsBoardFull())
            {
                _gameState.IsGameOver = true;
                _gameState.Winner = 'D'; // D for Draw
            }
            else
            {
                _gameState.CurrentPlayer = _gameState.CurrentPlayer == 'X' ? 'O' : 'X';
            }

            return _gameState;
        }

        private bool CheckWin(char player)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((_gameState.Board[i, 0] == player && _gameState.Board[i, 1] == player && _gameState.Board[i, 2] == player) ||
                    (_gameState.Board[0, i] == player && _gameState.Board[1, i] == player && _gameState.Board[2, i] == player))
                {
                    return true;
                }
            }

            if ((_gameState.Board[0, 0] == player && _gameState.Board[1, 1] == player && _gameState.Board[2, 2] == player) ||
                (_gameState.Board[0, 2] == player && _gameState.Board[1, 1] == player && _gameState.Board[2, 0] == player))
            {
                return true;
            }

            return false;
        }

        private bool IsBoardFull()
        {
            foreach (var cell in _gameState.Board)
            {
                if (cell == '\0')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
