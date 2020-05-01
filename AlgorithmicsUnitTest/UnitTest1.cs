using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace AlgorithmicsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public delegate void ResultCallback(int responseCode);

        public delegate void ResultCallbacks(int responseCode);


        [TestMethod]
        public void BinaryGap()
        {
            Assert.AreEqual(Algorithmics.Codility.BinaryGap.Solution(9), 2);
            Assert.AreEqual(Algorithmics.Codility.BinaryGap.Solution(529), 4);
            Assert.AreEqual(Algorithmics.Codility.BinaryGap.Solution(20), 1);
            Assert.AreEqual(Algorithmics.Codility.BinaryGap.Solution(15), 0);
            Assert.AreEqual(Algorithmics.Codility.BinaryGap.Solution(32), 0);
            Assert.AreEqual(Algorithmics.Codility.BinaryGap.Solution(1041), 5);
        }

        [TestMethod]
        public void CyclicRotation()
        {
            Assert.IsTrue(HelperTest.AreEqual(Algorithmics.Codility.CyclicRotation.Solution(new int[] { 3, 8, 9, 7, 6 }, 1), new int[] { 6, 3, 8, 9, 7 }));
            Assert.IsTrue(HelperTest.AreEqual(Algorithmics.Codility.CyclicRotation.Solution(new int[] { 3, 8, 9, 7, 6 }, 3), new int[] { 9, 7, 6, 3, 8 }));
            Assert.IsTrue(HelperTest.AreEqual(Algorithmics.Codility.CyclicRotation.Solution(new int[] { 0, 0, 0 }, 1), new int[] { 0, 0, 0 }));
            Assert.IsTrue(HelperTest.AreEqual(Algorithmics.Codility.CyclicRotation.Solution(new int[] { 1, 2, 3, 4 }, 4), new int[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void OddOccurrencesInArray()
        {
            Assert.AreEqual(Algorithmics.Codility.OddOccurrencesInArray.Solution2(new int[] { 9, 3, 9, 3, 9, 7, 9 }), 7);
            Assert.AreEqual(Algorithmics.Codility.OddOccurrencesInArray.Solution2(new int[] { 5 }), 5);
        }

        [TestMethod]
        public void FrogJmp()
        {
            //Algorithmics.Codility.FrogJmp.Solution();
        }

        [TestMethod]
        public void Test()
        {
            string p1 = "", p2;
            var r = MyMethod(ref p1, out p2);

            //var type = typeof(UnitTest1);
            //var attribute = type.GetCustomAttribute<TestClassAttribute>();
            //var s = Attribute.GetCustomAttribute(typeof(UnitTest1), typeof(TestClassAttribute));
            //var w = Attribute.GetCustomAttribute(typeof(UnitTest1), typeof(TestClassAttribute));
        }

        public string MyMethod(ref string p1, out string p2)
        {
            p2 = "";
            return "";
        }
    }

    public static class ClaseTestDelegates
    {
        public delegate void AuthCallback(bool validUser);
        public static AuthCallback loginCallback = Login;

        public static void Login(bool ss)
        {
            Console.WriteLine("Valid user!");
        }

        public static void BB()
        {
            loginCallback(true);
        }
    }



}
