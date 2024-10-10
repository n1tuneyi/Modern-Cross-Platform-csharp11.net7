Console.Write("Enter a name: ");

string name = Console.ReadLine()!;
string? s = null;

if(name == null)
{
    Console.WriteLine("You didn't enter a name");
    return;
}

Console.WriteLine($"Hello, {name} has {name.Length} characters!");