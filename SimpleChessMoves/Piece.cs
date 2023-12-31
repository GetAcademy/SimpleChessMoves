﻿namespace SimpleChessMoves
{
    internal class Piece
    {
        public string Symbol { get; }
        private readonly string _type;

        public Piece(string type, string symbol)
        {
            _type = type;
            Symbol = symbol;
        }

        public bool Move(string fromPosition, string toPosition)
        {
            if (_type == "Rook")
            {
                return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
            }
            if (_type == "Bishop")
            {
                var diffCol = fromPosition[0] - toPosition[0];
                var diffRow = fromPosition[1] - toPosition[1];
                return Math.Abs(diffRow) == Math.Abs(diffCol);
            }
            return true;
        }
    }
}
