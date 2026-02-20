using IfTask;
using NUnit.Framework;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FirstSecondLowestTest()
        {
            int firstInt = 10;

            int secondInt = 5;

            int thirdInt = 30;

            var lowestMultiplication = Logic.Lowest(firstInt, secondInt, thirdInt);
            Assert.That(50, Is.EqualTo(lowestMultiplication));
        }
    }
}
