using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matrix.Tests
{
    [TestClass]
    public class WalkinMatrixTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ZeroSizedTest()
        {
            WalkInMatrix matrix = new WalkInMatrix(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeSizeTest()
        {
            WalkInMatrix matrix = new WalkInMatrix(-7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OutOfRangeTest()
        {
            WalkInMatrix matrix = new WalkInMatrix(102);
        }

        [TestMethod]
        public void SizeOneTest()
        {
            WalkInMatrix matrix = new WalkInMatrix(1);

            Assert.IsTrue(matrix.ToString() == string.Format("  1\r\n"));
        }

        [TestMethod]
        public void SizeTwoTest()
        {
            WalkInMatrix matrix = new WalkInMatrix(2);

            Assert.IsTrue(matrix.ToString() == string.Format("  1  4\r\n  3  2\r\n"));
        }

        [TestMethod]
        public void SizeThreeTest()
        {
            WalkInMatrix matrix = new WalkInMatrix(3);

            Assert.IsTrue(matrix.ToString() == string.Format("  1  7  8\r\n  6  2  9\r\n  5  4  3\r\n"));
        }

        [TestMethod]
        public void SizeSixTest()
        {
            WalkInMatrix matrix = new WalkInMatrix(6);

            Assert.IsTrue(matrix.ToString() == string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n",
                "  1 16 17 18 19 20",
                " 15  2 27 28 29 21",
                " 14 31  3 26 30 22",
                " 13 36 32  4 25 23",
                " 12 35 34 33  5 24",
                " 11 10  9  8  7  6"));
        }
    }
}
