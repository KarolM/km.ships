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
        
        [TestMethod()]
        public void GridReference()
        {
            Grid b = new Grid();
            Square s = b['A', 1];
            Assert.AreEqual(b['A', 1], s);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Cannot find square with address Z1000")]
        public void GridIncorrectAddress()
        {
            Grid b = new Grid();
            Square s = b['Z', 1000];
            Assert.Fail("It should never get here");
        }

        [TestMethod()]
        public void GridUntytpicalSize()
        {
            Grid b = new Grid(20, 20);
            Assert.AreEqual(20, b.colSize);
            Assert.AreEqual(20, b.rowSize);
            Square s = b['A', 20];
            Assert.AreEqual('A', s.Column);
            Assert.AreEqual(20, s.Row);
        }
    }
}