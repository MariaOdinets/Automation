using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTest.L16_HW_Herokuapp
{
    public class Checkboxes : BaseTest
    {
        [SetUp]
        public void SetUp ()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");
        }

        [Test]
        public void CheckboxCondition() 
        {         
            IList<IWebElement> checkboxes = Driver.FindElements(By.CssSelector("[type=checkbox]"));

            Assert.That(!checkboxes[0].Selected);
            checkboxes[0].Click();
            Assert.That(checkboxes[0].Selected);

            Assert.That(checkboxes[1].Selected);
            checkboxes[1].Click();
            Assert.That(!checkboxes[1].Selected);
        }
    }
}