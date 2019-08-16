using Algo;
using Moq;
using NUnit.Framework;

namespace TU
{
    internal class SubArrayWithGivenSumTest
    {
        [Test]
        [Description(" Get Sub array ith given sum")]
        public void Algo_SubArrayWithGivenSum()
        {
            //arrange
            var mockAlgoSubArray = new Mock<SubArrayWithGivenSum>();
            int[] iarray = new int[] { 1, 2, 3 };
            var expectedResult = new int[] { 2 };
            mockAlgoSubArray.Setup(_ => _.GetSubArrayWithGivenSum(iarray, 2)).Returns(expectedResult);

            //act
            var sut = mockAlgoSubArray.Object.GetSubArrayWithGivenSum(iarray, 2);

            //assert
            Assert.AreEqual(sut, expectedResult);
        }
    }
}