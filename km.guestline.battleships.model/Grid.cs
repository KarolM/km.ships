using System;
using System.Collections.Generic;
using System.Linq;


namespace km.guestline.battleships
{
    public class Grid
    {
        public int colSize { get; } = 10;
        public int rowSize { get; } = 10;

        public Grid()
        {
            CreateSquares();
        }

        public Square this[char column, int row]
        {
            get
            {
                return null;
            }
        }

        private void CreateSquares()
        {
            var colmnAddrss = Enumerable.Range(65, colSize).Select(x => (char)x);
        }

        private int GetColumnAddressIndex(char columnAddress)
        {
            return (int)columnAddress;
        }

        private int GetColumnIndexAddress(int columnIndex)
        {
            return (char)columnIndex;
        }
    }
}
