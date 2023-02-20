using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Calculator
{
    public class Result

    {

        public static double CalcResult(int operation, double x, double y)
        {
            double result = 0;
            
            if (operation == 1)
            {
                result = x + y;
            }

            if (operation == 2)
            {
                result = x - y;
            }

            if (operation == 3)
            {
                result = x / y;
            }

            if (operation == 4)
            {
                result = x * y;
            }

            return result;
        }


    }
}
