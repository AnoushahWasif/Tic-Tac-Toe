namespace TicTacToe.Model
{
    public class GameState
    {
        public char[,] Board { get; set; } = new char[3, 3];
        public char CurrentPlayer { get; set; } = 'X';
        public bool IsGameOver { get; set; } = false;
        public char Winner { get; set; } = ' ';
    }
}
