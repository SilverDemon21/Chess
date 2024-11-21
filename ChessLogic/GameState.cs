﻿namespace ChessLogic
{
    public class GameState
    {
        public Board Board {  get;  }
        public Player CurrentPlayer { get; private set;}
        
        public GameState(Player player, Board board)
        {
            CurrentPlayer = player;
            Board = board;
        }

        public IEnumerable<Move> LegalMovesForPiece(Position pos)
        { 
            if (Board.IsEmpty(pos) || Board[pos].Color != CurrentPlayer)
            {
                return Enumerable.Empty<Move>();
            }


            Piece piece = Board[pos];
            IEnumerable<Move> moveCandidates = piece.GetMoves(pos, Board);
            return piece.GetMoves(pos,Board);
            //return moveCandidates.Where(move => move.IsLegal(Board));
        }

        public void MakeMove(Move move)
        {
            move.Execute(Board);
            CurrentPlayer = CurrentPlayer.Opponent();
        }


    }
}