using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Calculator
{
    public class OperationPrint
    {

        public static string ResultOperationPrint(string operation, string ADDITION, string SUBTRACTION, string DIVISION, string MULTIPLICATION)
        {
            string operationPrint = "";

            if (operation == ADDITION)
            { operationPrint = "addition +"; }

            if (operation == SUBTRACTION)
            { operationPrint = "subtraction -"; }

            if (operation == DIVISION)
            { operationPrint = "division /"; }

            if (operation == MULTIPLICATION)
            { operationPrint = "multiplication *"; }

            return operationPrint;
        }

    }
}
