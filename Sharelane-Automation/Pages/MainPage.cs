using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.Sharelane_Automation.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(WebDriver driver): base(driver) { }

        By EmailInputLocator = By.XPath("//*[@name = 'email']");
        By PasswordInputLocator = By.XPath("//*[@name = 'password']");
        By LoginButtonLocator = By.XPath("//*[@value = 'Login']");
        By SearchInput = By.XPath("//*[@name = 'keyword']");
        By SearchButton = By.XPath("//*[@value = 'Search']");
        By ErrorMessage = By.CssSelector(".error_message");
        By SignUpButton = By.XPath("//a[contains(@href, 'register')]");

        public void EnterEmail(string email)
        {
            Driver.FindElement(EmailInputLocator).SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Driver.FindElement(PasswordInputLocator).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            Driver.FindElement(LoginButtonLocator).Click();
        }
        public void ClickSearchButton() 
        { 
            Driver.FindElement(SearchButton).Click();
        }

        public void EnterSearchKeyphrase(string searchKeyphrase) 
        {
            Driver.FindElement(SearchInput).SendKeys(searchKeyphrase);
        }

        public bool IsErrorMessageDisplayed()
        {
            return Driver.FindElement(ErrorMessage).Displayed;
        }

        public void ClickSignUpButton()
        {
            Driver.FindElement(SignUpButton).Click();
        }

        public void Login(string email, string password)
        {
            EnterEmail(email);
            EnterPassword(password);
            ClickLoginButton();
        }
    }
}