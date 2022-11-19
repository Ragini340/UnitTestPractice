using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SampleUnitTestPractice;
using Moq;

namespace UnitTestPractice
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void getNumberTypeTest()
        {
            int num = 11;
            var primeService = new Mock<PrimeService>();
            primeService.Setup(x => x.IsPrime(num)).Returns(true);

            SampleUnitTestPractice.NumberType numberType = new NumberType();
            Assert.AreEqual(numberType.getNumberType(primeService.Object, num),"Prime");

            num = 12;
            primeService.Setup(x => x.IsPrime(num)).Returns(false);
            Assert.AreEqual(numberType.getNumberType(primeService.Object, num), 
                "Not Prime");

        }
    }
}
