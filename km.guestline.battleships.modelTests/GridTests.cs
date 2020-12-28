using Microsoft.VisualStudio.TestTools.UnitTesting;
using km.guestline.battleships;
using System;
using System.Collections.Generic;
using System.Text;

namespace km.guestline.battleships.Tests
{
    [TestClass()]
    public class GridTests
    {
        [TestInitialize()]
        public void Before()
        {

        }

        [TestMethod()]
        public void GridTest()
        {
            Grid b = new Grid();
            Assert.AreEqual(10, b.colSize);
            Assert.AreEqual(10, b.rowSize);                        
        }

        [TestMethod()]
        public void GridInitialize()
        {
            Grid b = new Grid();
            Square s = b['A', 1];
            Assert.AreEqual('A', s.Column);
            Assert.AreEqual(1, s.Row);
        }
    }
}