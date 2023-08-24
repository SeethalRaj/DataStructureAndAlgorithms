using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureAndAlgorithms.Test.LeetCode
{
    [TestClass]
    public class _767_ReorganizeStringTest
    {
        [TestMethod]
        public void ReorganizeStringTest1()
        {
            var result = DataStructureAndAlgorithms.LeetCode._767_ReorganizeString.ReorganizeString("xxxertvv");
            Assert.AreEqual("xrxtxvev", result);
        }

        [TestMethod]
        public void ReorganizeStringTest2()
        {
            var result = DataStructureAndAlgorithms.LeetCode._767_ReorganizeString.ReorganizeString("xxer");
            Assert.AreEqual("xexr", result);
        }

        [TestMethod]
        public void ReorganizeStringTest3()
        {
            var result = DataStructureAndAlgorithms.LeetCode._767_ReorganizeString.ReorganizeString("xxxxxxe");
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ReorganizeStringTest4()
        {
            var result = DataStructureAndAlgorithms.LeetCode._767_ReorganizeString.ReorganizeString("");
            Assert.AreEqual(string.Empty, result);
        }
    }
}
