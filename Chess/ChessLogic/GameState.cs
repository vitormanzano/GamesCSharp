namespace ChessLogic
{
    public class GameState
    {
        public Board Board { get; set; }
        public Player CurrentPlayer { get; set; }

        public GameState(Player player, Board board)
        {
            CurrentPlayer = player;
            Board = board;
        }
    }
}
