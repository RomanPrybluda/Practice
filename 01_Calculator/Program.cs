
using _01_Calculator;

// Console window property

Console.Title = "___Simple calculator___";
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WindowWidth = 80;

string reply;

do
{
    string operation;
    bool operationIsCorrected;
    const string ADDITION = "+", SUBTRACTION = "-", DIVISION = "/", MULTIPLICATION = "*";
    
    // Check input operation

    do
    {    
        // Menu
        Console.WriteLine("For addition       +");
        Console.WriteLine("For subtraction    -");
        Console.WriteLine("For division       /");
        Console.WriteLine("For multiplication *");
        
        Console.Write("\nInput type operation: ");
        operation = Console.ReadLine();

        {
            switch (operation)
            {
                case ADDITION:
                case SUBTRACTION:
                case DIVISION:
                case MULTIPLICATION:
                    {
                        operationIsCorrected = true;
                        break;
                    }
                default:
                    {
                        operationIsCorrected = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nInput correct operation, please.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }

            }
        }
    }

    while (operationIsCorrected == false);

    Console.Clear();
    
    string operationPrint = OperationPrint.ResultOperationPrint(operation, ADDITION, SUBTRACTION, DIVISION, MULTIPLICATION);
    Console.WriteLine($"Operation is: {operationPrint}");
    
    Console.Write("Input X: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Input Y: ");
    double y = Convert.ToDouble(Console.ReadLine());
    
    double result = Result.CalcResult(operation, y, x, ADDITION, SUBTRACTION, DIVISION, MULTIPLICATION);

    Console.WriteLine($"Result: {result:F2}");

    Console.WriteLine("\nDo you want to continue? (y/n)");
    reply = Console.ReadLine();


    if (reply.ToLower() == "y")
    {
        Console.Clear();
    }

}

while (reply.ToLower() == "y");

Console.WriteLine("\nGood-bye");

