using NUnit.Framework;
using LinkedListDS;
namespace LinkedListNUnitTest
{
    public class Tests
    {
        LinkedList linkedList;
        [SetUp]
        public void Setup()
        {
            linkedList = new LinkedList();
        }

        [TestCase(30)]
        public void SearchValue_ReturnTrue(int searchValue)
        {
            bool expected = true;
            Assert.AreEqual(expected, linkedList.Search(searchValue));
        }
    }
}