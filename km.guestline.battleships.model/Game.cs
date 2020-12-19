using System;
using System.Collections.Generic;
using System.Text;

namespace km.guestline.battleships.model
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player NextMoveBy { get; set; }

        public Game(Player player1, Player player2, StartingPlayerEnum starter = StartingPlayerEnum.First)
        {
            this.Player1 = player1;
            this.Player2 = player2;

            switch (starter)
            {
                case StartingPlayerEnum.First:
                    NextMoveBy = player1;
                case StartingPlayerEnum.Second:
                    NextMoveBy = player2;

            }
        }

        public enum StartingPlayerEnum
        {
            First, 
            Second
        }
    }
}
