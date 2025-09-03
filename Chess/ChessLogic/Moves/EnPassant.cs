namespace ChessLogic.Moves
{
    public class EnPassant : Move
    {
        public override MoveType Type => MoveType.EnPassant;

        public override Position FromPosition { get; }

        public override Position ToPosition { get; }
        
        private readonly Position capturedPos;

        public EnPassant(Position from, Position to)
        {
            FromPosition = from;
            ToPosition = to;
            capturedPos = new Position(from.Row, to.Column);
        }

        public override bool Execute(Board board)
        {
            new NormalMove(FromPosition, ToPosition).Execute(board);
            board[capturedPos] = null;

            return true;
        }
    }
}
