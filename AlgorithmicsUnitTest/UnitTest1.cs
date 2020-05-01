using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Algorithmics.Codility.FrogJmp.Solution(10, 30, 5);
        }
    }
}