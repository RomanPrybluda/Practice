using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Calculator
{
    public class Result

    {

        public static double CalcResult(string operation, double x, double y, string ADDITION, string SUBTRACTION, string DIVISION, string MULTIPLICATION)
        {
            double result = 0;
            
            if (operation == ADDITION)
            {
                result = x + y;
            }

            if (operation == SUBTRACTION)
            {
                result = x - y;
            }

            if (operation == DIVISION)
            {
                result = x / y;
            }

            if (operation == MULTIPLICATION)
            {
                result = x * y;
            }

            return result;
        }


    }
}
