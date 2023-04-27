using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    internal class CalculatorTests
    {
        double randomNumber;
        double result;
        int randomNumber2;

        Calculator calculator;

        [OneTimeSetUp]
        public void SetUpClass()
        {
            randomNumber = new Random().NextDouble();
            randomNumber2 = new Random().Next(-100, 100);
            calculator = new Calculator();
        }

        [SetUp]
        public void SetUpMethod()
        {
            randomNumber = Math.Round(randomNumber, 3);
        }

        [Test]
        [Retry(2)]
        public void TestSum()
        {
            var result = calculator.Sum(randomNumber, randomNumber2);

            Assert.That(result, Is.EqualTo(0), $"Failed - {randomNumber} + {randomNumber2} = {result}");
        }

        [Test, Description("Test substraction int from double and rounding up result to 3 decimal places")]
        [Retry(3)]
        public void TestSubtraction()
        {
            var result = calculator.Subtract(randomNumber, randomNumber2);

            Assert.That(result, Is.LessThan(6), $"Failed: {randomNumber} - {randomNumber2} = {result}");
        }

        [Test]
        [Retry(1)]
        public void TestMultipication(
            [Values(0, 9, 1)] int operand1,
            [Range(10, 20, 2)] int operand2)

        {
            int expectedResult = 55;
            var result = calculator.Multiply(operand1, operand2);

            Assert.AreEqual(expectedResult, result, $"{operand1} * {operand2} is {result}, not {expectedResult}");
        }

        [Test]
        [TestCase(10,2)]
        [Retry(3)]
        public void TestDivision(
            [Values(0, 100, 1)] int operand1,
            [Range(1, 10, 5)] int operand2)
        {
            var result = calculator.Divide(operand1, operand2);
        }

        [TearDown]
        public void TearDownClass()
        {

        }

        [OneTimeTearDown]
        public void TearDownMethod()
        {

        }
    }
}