using Algo;
using NUnit.Framework;
using System;

namespace TU
{
    /// <summary>
    /// Test Nombre Premier Service
    /// </summary>
    public class TestNombrePremierServic
    {
        [Test]
        [Description("args parameter should not be null")]
        public void PrimeNumberService_GetPrimeNumbers()
        {
            //arrange
            var moqPrimeNumberService = new PrimeNumberService();
            int? number = 3;
            var expectedResult = new int[] { 3, 2 };

            //act
            var sut = moqPrimeNumberService.GetPrimeNumbers(3);

            //assert
            Assert.AreEqual(expectedResult, sut);
        }

        [Test]
        [Description("args parameter should be more than two")]
        public void PrimeNumberService_GetPrimeNumbers_Throw_ArgumentOutOfRangeException()
        {
            //arrange
            var moqPrimeNumberService = new PrimeNumberService();
            var number = 1;
            var expectedException = new ArgumentOutOfRangeException();

            //act

            var sut = Assert.Throws<ArgumentOutOfRangeException>(
                      () => moqPrimeNumberService.GetPrimeNumbers(1),
                      "Should throw ArgumentOutOfRangeException");

            //assert
            Assert.AreEqual(expectedException.InnerException, sut.InnerException);
        }

        [Test]
        [Description("args parameter should not be null")]
        public void PrimeNumberService_GetPrimeNumbers_Throw_ArgumentNullException()
        {
            //arrange
            var moqPrimeNumberService = new PrimeNumberService();
            int? number = null;
            var expectedResult = new ArgumentNullException();

            //act
            var sut = Assert.Throws<ArgumentNullException>(
                () => moqPrimeNumberService.GetPrimeNumbers(null),
                "should throw ArgumentNullException");

            //assert
            Assert.AreEqual(expectedResult.InnerException, sut.InnerException);
        }
    }
}