using Algo;

using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TU
{
    public class FizzBuzzTest
    {


        [Test]
        public void Fizz_Buzz_FizzBuzz() 
        {
            //arrange
            var moqFizzBuzz = new Moq.Mock<FizzBuzzAlgo>();
            var expectedResult = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7" };
            moqFizzBuzz.Setup(e => e.FizzBuzz(7)).Returns(expectedResult);

            //act
            var sut = moqFizzBuzz.Object.FizzBuzz(7);

            //assert
            Assert.AreEqual(sut, expectedResult);

        }

    }
}
