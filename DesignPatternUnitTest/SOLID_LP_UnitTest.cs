using System;
using DesignPatterns.SOLID.LP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternUnitTest
{
    [TestClass]
    public class SOLID_LP_UnitTest
    {
        [TestMethod]
        public void Test1()
        {
            var rc = new Rectangle(2, 3);
            var s1 = MyClient.UseIt(rc);
            Assert.AreEqual("Expected area of 20, got 20", s1);

            var sq = new Square(5);
            var s2 = MyClient.UseIt(sq);
            Assert.AreEqual("Expected area of 100, got 100", s2);
        }
    }
}
