

using Algo;
using NUnit.Framework;

namespace TU
{
   public class FibonacciNumberTest
    {
        [Test]
       public void FibonacciNumber_GetFibonacciNumber()
        {
            //arrange
            var moqFibonacciNumber = new  Moq.Mock<FibonacciNumber>();
            var expectedResult = new int[] { 8 };
            moqFibonacciNumber.Setup(_ => _.GetFibonacciNumber(new int[] { 8 })).Returns(expectedResult);

            //act
            var sut = moqFibonacciNumber.Object.GetFibonacciNumber(new int[] { 8 });


            //assert
            Assert.AreEqual(sut, expectedResult);
        }
    }
}
