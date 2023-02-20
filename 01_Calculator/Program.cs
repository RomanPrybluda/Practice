﻿
using _01_Calculator;

Console.Title = "___Simple calculator___";

string reply;

do
{
    //Menu
    Console.WriteLine("For addition       + input 1");
    Console.WriteLine("For subtraction    - input 2");
    Console.WriteLine("For division       / input 3");
    Console.WriteLine("For multiplication * input 4");

    //Input
    Console.WriteLine("\nInput type operation:");
    int operation = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    string operationPrint = OperationPrint.ResultOperationPrint(operation);
    Console.WriteLine($"Operation is: {operationPrint}");

    Console.WriteLine("Input X:");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input Y:");
    int y = Convert.ToInt32(Console.ReadLine());

    int result = Result.CalcResult(operation, y, x);

    Console.WriteLine($"Result: {result}");

    Console.WriteLine("Do you want to continue? (y/n)");
    reply = Console.ReadLine();


    if (reply.ToLower() == "y")
    {
        Console.Clear();
    }

}

while (reply.ToLower() == "y");

Console.WriteLine("\nGood-bye");

