using System;
using Algo;
using Moq;
using NUnit.Framework;

namespace TU
{
    public class RotateArrayTest
    {
        [Test]
        public void RotateArray_GetRotateArray()
        {
            //arrange
            var moqRotateArray = new Mock<RotateArray>();
            var expectedResult = new int[] { 3, 4, 5, 1, 2 };
            moqRotateArray.Setup(_ => _.GetRotateArray(new int[] { 1, 2, 3, 4, 5 }, 2))
                          .Returns(expectedResult);

            //act
            var sut = moqRotateArray.Object.GetRotateArray(new int[] { 1, 2, 3, 4, 5 }, 2);

            //assert

            Assert.AreEqual(sut, expectedResult);
        }

        [Test]
        public void RotateArray_Throw_Exception()
        {
            //arrange
            var moqRotateArray = new RotateArray();
            var expectedResult = new ArgumentNullException();

            //act
            var sut = Assert.Throws<ArgumentNullException>(
                () => moqRotateArray.GetRotateArray(null, -1),
                "should not be null parameters and number should be more than 0");

            //act
            Assert.AreEqual(sut.InnerException, expectedResult.InnerException);

        }


    }
}