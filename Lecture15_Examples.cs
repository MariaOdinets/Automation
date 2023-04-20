namespace NUnitTest
{
    public class Tests
    {
        int randomInt;
        Calculator calculator;

        [OneTimeSetUp]
        public void SetUpForClass()
        {
            randomInt = new Random().Next(16, 30);
            calculator = new Calculator();
        }

        [SetUp]
        public void SetupForEachMethod()
        {
            randomInt = new Random().Next(0, 15);
        }


        [Test]
        public void IsOdd()
        {
            Console.WriteLine(randomInt.ToString());
            Assert.True(randomInt % 2 == 0);
        }

        [Test]
        public void IsEven()
        {
            Console.WriteLine(randomInt.ToString());
            Assert.True(randomInt % 2 != 0);
        }

        [Test]

        [TestCase(1, 2, 3)]
        [TestCase(-4, -8, -12)]
        [TestCase(-4, -8, 12)]
        public void TestSum(int operand1, int operand2, int result)
        {
            //operand1 = 1;
            //operand2 = 2;
            //result = 56;

            var actualResult = calculator.Sum(operand1, operand2);

            //Assert.AreEqual(result, actualResult, $"Sum {operand1} + {operand2} = {actualResult}");
            //Assert.False(actualResult != result);
            Assert.That(actualResult, Is.EqualTo(result), $"Sum {operand1} + {operand2} = {actualResult}");
        }

        [Test]

        public void TestSumRange(
            [Values(1, 10, 2)] int operand1,
            [Range(11, 20, 3)] int operand2)
        //[Random(1, 10, 4)] //range + count

        {
            var actualResult = calculator.Sum(operand1, operand2);

            Assert.AreEqual(actualResult, actualResult - 1, $"Failed");
        }

        [TearDown]
        public void TearDown()
        {

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }
    }
}