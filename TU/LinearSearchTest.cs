using Algo;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TU
{

    class LinearSearchTest
    {
        [Test]
        [Description("")]
        public void LinearTest_IndexOFNumer()
        {
            //arrange 
            var moqSearchService = new Moq.Mock<SearchService>();
            var expectedResult = Array.IndexOf(new int[It.IsAny<int>()], It.IsAny<int>());
            moqSearchService.Setup(_ => _.GetIndexLinearSearchNumber(new int[It.IsAny<int>()], It.IsAny<int>())).Returns(expectedResult);

            //act
            var sut = moqSearchService.Object.GetIndexLinearSearchNumber(new int[It.IsAny<int>()], It.IsAny<int>());


            //assert
            Assert.AreEqual(sut, expectedResult);

        }
    }
}
