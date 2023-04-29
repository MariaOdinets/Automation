using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.L16_HW_Herokuapp
{
    public class Inputs : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/inputs");
        }

        [Test]
        public void InputsTest()
        {

        }
    }
}