using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.Sharelane_Automation.Pages
{
    public class BookPage : BasePage
    {
        public BookPage(WebDriver driver) : base(driver) { }

        By AddToCartButton = By.XPath("//a[contains(@href, 'add_to_cart.py?book_id=')]");
        By ConfirmationMessage = By.CssSelector(".confirmation_message");

        public void ClickAddToCartButton()
        {
            Driver.FindElement(AddToCartButton).Click();
        }
    }
}