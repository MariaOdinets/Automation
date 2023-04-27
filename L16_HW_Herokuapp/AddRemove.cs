using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.L16_HW_Herokuapp
{
    internal class AddRemove 
    {
        WebDriver ChromeDriver = new ChromeDriver();

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ChromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
        }

        [Test]

        public void AddElements()
        {           
            var addButton = ChromeDriver.FindElement(By.XPath("//button[text()='Add Element']"));

            addButton.Click();
            addButton.Click();            
        }

        [Test]
        public void RemoveElements()
        {
            ChromeDriver.FindElement(By.XPath("//button[text()='Delete']")).Click();
        }

        [Test]
        public void CheckNumberOfElements() 
        {
            var listElements = ChromeDriver.FindElements(By.TagName("button"));
            Console.WriteLine(listElements.Count());

            Assert.That(listElements.Equals(2));
        }
    }
}