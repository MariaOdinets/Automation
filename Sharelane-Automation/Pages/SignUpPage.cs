using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NUnitTest.Sharelane_Automation.Pages
{
    public class SignUpPage : BasePage
    {
        public SignUpPage(WebDriver driver) : base(driver) { }

        By ZipCodeInput = By.XPath("//*[@name = 'zip_code']");
        By ContinueButton = By.XPath("//*[@value = 'Continue']");
        By FirstNameInput = By.XPath("//*[@name = 'first_name']");
        By EmailInput = By.XPath("//*[@name = 'email']");
        By PasswordInput = By.XPath("//*[@name = 'password1']");
        By ConfirmPasswordInput = By.XPath("//*[@name = 'password2']");
        By RegisterButton = By.XPath("//*[@value = 'Register']");
        By ConfirmationMessage = By.CssSelector(".confirmation_message");
        By ErrorMessage = By.CssSelector(".error_message");

        public void EnterZipCode(string zipCode)
        {
            Driver.FindElement(ZipCodeInput).SendKeys(zipCode);
        }

        public void ClickContinueButton()
        {
            Driver.FindElement(ContinueButton).Click();
        }

        public void EnterFirstName(string firstName)
        {
            Driver.FindElement(FirstNameInput).SendKeys(firstName);
        }

        public void EnterEmail(string email)
        {
            Driver.FindElement(EmailInput).SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Driver.FindElement(PasswordInput).SendKeys(password);
        }

        public void ConfirmPassword(string confirmPassword)
        {
            Driver.FindElement(ConfirmPasswordInput).SendKeys(confirmPassword);
        }

        public void ClickRegisterButton() 
        {
            Driver.FindElement(RegisterButton).Click();
        }

        public bool IsConfirmationMessageDisplayed()
        {
            return Driver.FindElement(ConfirmationMessage).Displayed;
        }

        public bool IsErrorMessageDisplayed()
        {
            return Driver.FindElement(ErrorMessage).Displayed;
        }

        public void SignUp(string zipCode, string firstName, string email, string password, string confirmPassword)
        {
            EnterZipCode(zipCode);
            ClickContinueButton();
            EnterFirstName(firstName);
            EnterEmail(email);
            EnterPassword (password);
            ConfirmPassword(confirmPassword);
            ClickRegisterButton();
        }
    }
}