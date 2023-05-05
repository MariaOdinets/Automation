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
        [SetUp]
        public void SetUpLocal()
        {
            Driver.Navigate().GoToUrl("https://www.sharelane.com/cgi-bin/main.py");
        }

        [Test]
        public void LoginInvalidCredentials()
        {
            string email = "username@123.com";
            string password = "password";

            Driver.FindElement(By.XPath("//*[@name = 'email']")).SendKeys(email);
            Driver.FindElement(By.XPath("//*[@name = 'password']")).SendKeys(password);
            Driver.FindElement(By.XPath("//*[@value = 'Login']")).Click();

            var errorMessage = Driver.FindElement(By.CssSelector(".error_message"));

            Assert.That(errorMessage.Displayed);
        }
    }
}
