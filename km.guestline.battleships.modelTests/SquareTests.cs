using Microsoft.VisualStudio.TestTools.UnitTesting;
using km.guestline.battleships;
using System;
using System.Collections.Generic;
using System.Text;

namespace km.guestline.battleships.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Square s = new Square("B", 10);
            Assert.AreEqual("B10", s.ToString());
        }
    }
}