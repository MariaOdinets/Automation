using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTest.L16_HW_Herokuapp
{
    internal class Dropdown : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
        }

        [Test]
        public void DropdownCheck() 
        {
            var dropdown = Driver.FindElement(By.Id("dropdown"));
            var elements = dropdown.FindElements(By.TagName("option"));

            Assert.That(elements.Count > 0);
            
            foreach (var element in elements) 
            {
                if (element.Enabled)
                {
                    element.Click();
                    Assert.That(element.Selected);
                }               
            }
        }
    }
}