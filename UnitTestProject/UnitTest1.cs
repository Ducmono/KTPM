using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestPtb1.csv", "TestPtb1#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Test_Ptb1_09_LeMinhDuc()
        {
            double a = double.Parse(TestContext.DataRow[0].ToString());
            double b = double.Parse(TestContext.DataRow[1].ToString());
            double expected = double.Parse(TestContext.DataRow[2].ToString());
            Result i = new Result(a, b);
            double actual = i.Execute("b1");
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestPtb2.csv", "TestPtb2#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Test_Ptb2_09_LeMinhDuc()
        {
            double a = double.Parse(TestContext.DataRow[0].ToString());
            double b = double.Parse(TestContext.DataRow[1].ToString());
            double c = double.Parse(TestContext.DataRow[2].ToString());
            double expected = double.Parse(TestContext.DataRow[3].ToString());
            Result i = new Result(a, b, c);
            double actual = i.Execute("b2");
            Assert.AreEqual(expected, actual);
        }
    }
}
