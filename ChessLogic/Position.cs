namespace ChessLogic
{
    public class Position
    {
        public int Row { get; set; } 
        public int Column { get; set; }

        public Position(int row, int column) 
        {
            Row = row;
            Column = column;
        }

        public Player SquareColor()
        {
            if ((Row + Column) % 2 == 0)
            {
                return Player.White;
            }
            return Player.Black;
        }





        public override bool Equals(object obj)
        {
            return obj is Position postion &&
                   Row == postion.Row &&
                   Column == postion.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }


        public static Position operator +(Position pos, Direction dir)
        {
            return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
        }
    }
}
