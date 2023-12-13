using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint6.TaskReview.V6.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.TaskReview.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidGetRandomMatrix()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            int n1 = -100;
            int n2 = -1;

            int[,] array = ds.GetRandomMatrix(n, m, n1, n2);

        }

        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int k = 1;
            int l = 2;
            int c = 0;

            int[,] array = { { -1, -6, -7 }, 
                             { -9, -50, -9 }, 
                             { -7, -15, -20 } };

            int res = ds.GetMatrix(array, c, k, l);
            int wait = 63;

            Assert.AreEqual(wait, res);
        }

        
    }
}
