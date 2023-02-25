Console.Write("Enter your name: ");
int nameCursorLeft = Console.CursorLeft;
int nameCursorTop = Console.CursorTop;
string name = Console.ReadLine();

Console.Write("Enter your age: ");
int ageCursorLeft = Console.CursorLeft;
int ageCursorTop = Console.CursorTop;
string ageString = Console.ReadLine();
int age = int.Parse(ageString);

Console.WriteLine($"Hello, {name}! You are {age} years old.");
