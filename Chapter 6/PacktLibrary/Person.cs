namespace Packt.Shared;
public class Person
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    public int AngerLevel;

    public event EventHandler? Shout;

    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            Shout?.Invoke(this, EventArgs.Empty);
        }
    }
}