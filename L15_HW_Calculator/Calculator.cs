using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.L15_HW_Calculator
{
    public class Calculator
    {
        public double Sum(double x, int y) => x + y;

        public double Subtract(double x, int y) => x - y;

        public int Divide(int x, int y) => x / y;

        public int Multiply(int x, int y) => x * y;
    }
}
