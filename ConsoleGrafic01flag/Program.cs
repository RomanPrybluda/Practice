
/* Application draw the flag of UKRAINE.
// The lenght and symbol we can choose.
// Flag proportion 1:3/H:L.*/

// Window properties

Console.Title = "Flag of UKRAINE";
Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;

// Input data

Console.Write("Input symbol for flag: ");
string symbolFlag = Console.ReadLine();

bool result;
int lengthFlag;

do
{
    Console.Write("Input lenght of flag (q-ty symbols): ");
    string lengthFlagInput = Console.ReadLine();
    result = int.TryParse(lengthFlagInput, out lengthFlag);

    if (result)
    {
        ;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Input an integer please.");
        Console.ForegroundColor = ConsoleColor.White;
    }

}
while (result == false);

// Height Flag

int heightFlag = lengthFlag / 3;
int heightFlagHalf = heightFlag / 2;

// Output

Console.WriteLine("");

Console.WriteLine(symbolFlag);

for ( int h2 = 0; h2 < heightFlagHalf; h2++)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(symbolFlag);
    
    for (int l = 0; l < lengthFlag; l++)
    {
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(symbolFlag);
    }

    Console.Write("\n");
}

for (int h2 = 0; h2 < heightFlagHalf; h2++)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(symbolFlag);

    for (int l = 0; l < lengthFlag; l++)
    {
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(symbolFlag);
    }

    Console.Write("\n");
}

for (int h2 = 0; h2 < heightFlagHalf; h2++)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(symbolFlag);
}