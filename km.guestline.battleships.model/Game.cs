﻿using System;
using System.Collections.Generic;
using System.Text;

namespace km.guestline.battleships.model
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player NextMoveBy { get; set; }

        public Game(Player player1, Player player2, StartingPlayer starter = StartingPlayer.Player1)
        {
            this.Player1 = player1;
            this.Player2 = player2;

            switch (starter)
            {
                case StartingPlayer.Player1:
                    NextMoveBy = player1;
                    break;
                case StartingPlayer.Player2:
                    NextMoveBy = player2;
                    break;
            }
        }

        public enum StartingPlayer
        {
            Player1, 
            Player2
        }
    }
}
