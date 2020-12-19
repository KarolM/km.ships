namespace km.guestline.battleships
{
    public class Square
    {
        public int Row { get; set; }
        public string Column { get; set; }


        public Square(string column, int row)
        {
            this.Column = column;
            this.Row = row;
        }

        public override string ToString()
        {
            return $"{Column}{Row}";
        }
    }
}