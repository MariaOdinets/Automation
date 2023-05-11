using NUnitTest.Sharelane_Automation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.Sharelane_Automation
{
    public class Search : BaseTest
    {
        MainPage MainPage { get; set; }

        [SetUp]
        public void SetUpLocal()
        {
            Driver.Navigate().GoToUrl("https://www.sharelane.com/cgi-bin/main.py");
            MainPage = new MainPage(Driver);
        }

        [Test]
        public void SearchSuccessful()
        {
            string searchKeyphrase = "Charles Dickens Great Expectations";

            MainPage.EnterSearchKeyphrase(searchKeyphrase);
            MainPage.ClickSearchButton();

            var AddToCartButton = Driver.FindElement(By.XPath("//a[contains(@href, 'add_to_cart.py?book_id=')]"));

            Assert.That(AddToCartButton.Displayed);
        }        
    }
}