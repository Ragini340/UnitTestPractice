using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleUnitTestPractice;
using System;

namespace UnitTestPractice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program Obj = new Program();

            String value = Obj.concat("Ragini", "Singh");

            Assert.AreEqual("RaginiSingh", value);  
        }
    }
}
