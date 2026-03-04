using IfTask;
namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void StandartTest()
    {
        int firstInt = 10;

        int secondInt = 5;

        int thirdInt = 30;

        var lowestMultiplication = Logic.Multiply(firstInt, secondInt, thirdInt);
        Assert.That(50, Is.EqualTo(lowestMultiplication));
    }
    [Test]
    public void NegativeTest()
    {
        int firstInt = 15;

        int secondInt = -4;

        int thirdInt = -10;

        var lowestMultiplication = Logic.Multiply(firstInt, secondInt, thirdInt);
        Assert.That(40, Is.EqualTo(lowestMultiplication));
    }
    [Test]
    public void ZeroTest()
    {
        int firstInt = 200;

        int secondInt = 0;

        int thirdInt = 2;

        var lowestMultiplication = Logic.Multiply(firstInt, secondInt, thirdInt);
        Assert.That(0, Is.EqualTo(lowestMultiplication));
    } 
    [Test]
    
    public void SameValue()
    {
        int firstInt = 40;

        int secondInt = 40;

        int thirdInt = 40;

        var lowestMultiplication = Logic.Multiply(firstInt, secondInt, thirdInt);
        Assert.That(40 * 40, Is.EqualTo(lowestMultiplication));
    }
}