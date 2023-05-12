using OpenQA.Selenium;

namespace NUnitTest.Sharelane_Automation.Pages
{
    public abstract class BasePage
    {
        public WebDriver Driver { get; set; }

        public BasePage(WebDriver driver)
        {
            Driver = driver;
        }
    }
}