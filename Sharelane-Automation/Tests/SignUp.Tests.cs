using NUnitTest.Sharelane_Automation.Pages;
using Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.Sharelane_Automation.Tests
{
    public class SignUp : BaseTest
    {
        private MainPage MainPage;
        private SignUpPage SignUpPage;

        [SetUp]
        public void SetUpLocal()
        {
            Driver.Navigate().GoToUrl("https://www.sharelane.com/cgi-bin/main.py");
            MainPage = new MainPage(Driver);
            SignUpPage= new SignUpPage(Driver);
            MainPage.ClickSignUpButton();
        }

        [Test]
        public void SignUpPositive()
        {
            string zipCode = RandomNumber.Next(00000,99999).ToString();
            string firstName = Name.First();
            string email = "12345@dfjndsj.ffj";
            string password = "77777";
            string confirmPassword = "77777";           

            SignUpPage.SignUp(zipCode, firstName, email, password, confirmPassword);

            Assert.That(SignUpPage.IsConfirmationMessageDisplayed());
        }

        [Test]
        public void SignUpInvalidZipCode()
        {
            string zipCode = Address.ZipCode();

            SignUpPage.EnterZipCode(zipCode);
            SignUpPage.ClickContinueButton();

            Assert.That(SignUpPage.IsErrorMessageDisplayed());
        }
    }
}