using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.L16_HW_Herokuapp
{
    internal class AddRemove : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
        }

        [Test]
        public void AddElements()
        {           
            var addButton = Driver.FindElement(By.XPath("//button[text()='Add Element']"));

            addButton.Click();
            addButton.Click();     
        }

        [Test]
        public void RemoveElements()
        {
            Driver.FindElement(By.XPath("//button[text()='Delete']")).Click();
        }

        [Test]
        public void CheckNumberOfElements() 
        {
            var listElements = Driver.FindElements(By.TagName("button"));
            Console.WriteLine(listElements.Count());

            Assert.That(listElements.Equals(2));
        }
    }
}