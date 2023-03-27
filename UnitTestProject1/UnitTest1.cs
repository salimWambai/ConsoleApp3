﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp3;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Add(
                10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Subtract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }

        private static void Test_MultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Multiply(10, 5);
            Assert.AreEqual(res, 2);
        }
    }
}
