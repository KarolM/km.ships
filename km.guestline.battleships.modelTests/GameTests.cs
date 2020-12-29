using Microsoft.VisualStudio.TestTools.UnitTesting;
using km.guestline.battleships.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace km.guestline.battleships.model.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void GameTest()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game g = new Game(p1, p2, Game.StartingPlayerEnum.Player1);
            Assert.AreEqual(g.NextMoveBy, p1);
            g = new Game(p1, p2, Game.StartingPlayerEnum.Player2);
            Assert.AreEqual(g.NextMoveBy, p2);
        }
    }
}