﻿using ChessLogic.Moves;

namespace ChessLogic
{
    public class NormalMove : Move
    {
        public override MoveType Type => MoveType.Normal;

        public override Position FromPosition { get; }

        public override Position ToPosition { get; }

        public NormalMove(Position from, Position to)
        {
            FromPosition = from;
            ToPosition = to;
        }

        public override bool Execute(Board board)
        {
            Piece piece = board[FromPosition];
            bool capture = board.IsEmpty(ToPosition);

            board[ToPosition] = piece;
            board[FromPosition] = null;
            piece.HasMoved = true;

            return capture || piece.Type == PieceType.Pawn;
        }
    }
}
