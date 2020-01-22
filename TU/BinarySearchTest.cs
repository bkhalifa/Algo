using Algo;
using Moq;
using NUnit.Framework;

namespace TU
{
    class BinarySearchTest
    {
        [Test]
        public void BinarySearchTest_GetIndexValue()
        {
            // arrange 
            var arr = new int[It.IsAny<int>()]; 
            var moqBinarySearch = new Moq.Mock<SearchService>();
            var exepectedResult = It.IsAny<int>();
            moqBinarySearch.Setup(_ => _.GetIndexValueBinarySearch(arr, It.IsAny<int>())).Returns(exepectedResult);
            
            //act
            var sut = moqBinarySearch.Object.GetIndexValueBinarySearch(arr, It.IsAny<int>());

            //assert
            Assert.AreEqual(sut, exepectedResult);

        }

    }
}
