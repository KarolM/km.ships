using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace km.guestline.battleships
{
    public class Grid
    {
        public int colSize { get; } = 10;
        public int rowSize { get; } = 10;

        private Dictionary<(char, int), Square> squares;

        public Grid()
        {
            CreateSquares();
        }

        public Square this[char column, int row]
        {
            get
            {
                if (squares.TryGetValue((column, row), out Square s))
                    return s;

                throw new Exception($"Cannot find square with address {column}{row}");
            }
        }

        private void CreateSquares()
        {
            var clmnAddrss = Enumerable.Range(65, colSize).Select(x => (char)x);
            var rwAddrss = Enumerable.Range(1, rowSize);
            squares = (from c in clmnAddrss
                       from r in rwAddrss
                       select new Square(c, r)).ToDictionary(x => (x.Column, x.Row), x => x);
        }
    }
}
