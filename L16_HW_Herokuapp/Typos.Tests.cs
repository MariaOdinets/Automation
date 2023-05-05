using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.L16_HW_Herokuapp
{
    public class Typos : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/typos");
        }

        [Test]
        public void TyposTest() 
        {
            IList<IWebElement> paragraphs = Driver.FindElements(By.TagName("p"));

            var text = paragraphs[1].GetAttribute("outerText");
            string expectedText = "Sometimes you'll see a typo, other times you won't.";

            Assert.That(text, Is.EqualTo(expectedText));
        }
    }
}