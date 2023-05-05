using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.L16_HW_Herokuapp
{
    public class Inputs : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/inputs");
        }

        [Test]
        public void InputsTestNumbers()
        {
            IWebElement input = Driver.FindElement(By.TagName("input"));            
            input.Click();

            input.SendKeys(Keys.ArrowUp + Keys.ArrowDown);
            var text = input.GetAttribute("value");

            Assert.That(text, !Is.Empty);
        }

        [Test]
        public void InputsTestLetters() 
        {
            IWebElement input = Driver.FindElement(By.TagName("input"));
            input.Click();

            input.SendKeys("any text !@#%^*^%");
            var text = input.GetAttribute("value");

            Assert.That(text, Is.Empty);
        }
    }
}