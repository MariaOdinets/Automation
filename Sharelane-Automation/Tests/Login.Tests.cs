using NUnitTest.Sharelane_Automation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.Sharelane_Automation
{
    public class Login : BaseTest
    {
        private MainPage MainPage;

        [SetUp]
        public void SetUpLocal()
        {
            Driver.Navigate().GoToUrl("https://www.sharelane.com/cgi-bin/main.py");
            MainPage = new MainPage(Driver);
        }

        [Test]
        public void LoginInvalidCredentials()
        {
            string email = "username@123.com";
            string password = "password";

            MainPage.Login(email, password);

            var errorMessage = Driver.FindElement(By.CssSelector(".error_message"));

            Assert.That(errorMessage.Displayed);
        }

        [Test]
        public void LoginEmptyCredentials() 
        {
            MainPage.Login("", "");

            var errorMessage = Driver.FindElement(By.CssSelector(".error_message"));

            Assert.That(errorMessage.Displayed);
        }
    }
}