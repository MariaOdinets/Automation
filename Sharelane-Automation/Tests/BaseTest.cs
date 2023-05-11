using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NUnitTest.Sharelane_Automation
{
    public class BaseTest
    {
        public WebDriver Driver { get; set; }

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Navigate().GoToUrl("https://www.sharelane.com/");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}