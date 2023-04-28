using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    [TestFixture]
    internal class Lecture16_Examples
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]

        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void SeleniumTestLecture()
        {
            ChromeDriver.Navigate().GoToUrl("https://www.sharelane.com");
            ChromeDriver.Quit();
        }

        [Test]
        public void InputTest()
        {
            ChromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/inputs");

            var input = ChromeDriver.FindElement(By.TagName("input"));

            input.SendKeys("123");
            input.Clear();

            input.SendKeys("456");
            input.Clear();

            input.Click();
            input.SendKeys("789");
        }

        [TearDown]

        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }
}