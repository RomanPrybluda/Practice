using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Calculator
{
    public class OperationPrint
    {

        public static string ResultOperationPrint(int operation)
        {
            string operationPrint = "";

            if (operation == 1)
            { operationPrint = "addition +"; }

            if (operation == 2)
            { operationPrint = "subtraction -"; }

            if (operation == 3)
            { operationPrint = "division /"; }

            if (operation == 4)
            { operationPrint = "multiplication *"; }

            return operationPrint;
        }

    }
}
