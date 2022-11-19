using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SampleUnitTestPractice;

namespace UnitTestPractice
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {   
            //Arranging
            SampleTestClass obj = new SampleTestClass();

            //Acting
            Boolean result = obj.testFunction();

            //Asserting
            Assert.AreEqual(true, result);
        }
    }
}
