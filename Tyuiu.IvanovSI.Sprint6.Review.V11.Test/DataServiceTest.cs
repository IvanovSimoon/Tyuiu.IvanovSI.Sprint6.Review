using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint6.Review.V11.Lib;
namespace Tyuiu.IvanovSI.Sprint6.Review.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int k = 1;
            int l = 4;
            int c = 1;
            int n = 5;
            int m = 5;
            int n1 = 3;
            int n2 = 9;

            int[,] array = ds.GetMatrix(n, m, n1, n2);

            int res = ds.GetMax(array, c, k, l);
            int wait = 9;

            Assert.AreEqual(res, res);
        }
    }
}
