using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.L16_HW_Herokuapp
{
    internal class Dropdown : AbstractSetUp
    {
        WebDriver ChromeDriver = new ChromeDriver();

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ChromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
        }
    }
}
