namespace Packt.Shared;

public partial class Person
{

    private string? favoritePrimaryColor;

    public string Origin
    {
        get
        {
            return string.Format("{0} was born on {1}",
            arg0: Name, arg1: HomePlanet);
        }
    }
    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - DateOfBirth.Year;

    public string? FavoriteIceCream { get; set; }

    public string? FavoritePrimaryColor
    {
        get
        {
            return favoritePrimaryColor ?? throw new ArgumentException("Primary Color is not yet set");
        }
        set
        {
            favoritePrimaryColor = (value?.ToLower()) switch
            {
                "red" or "green" or "blue" => value,
                _ => throw new ArgumentException(
                                    $"{value} is not a primary color. " +
                                    "Choose from: red, green, blue."),
            };
        }
    }

    public Person this[int index]
    {
        get
        {
            return Children[index];
        }
        set
        {
            Children[index] = value;
        }
    }

    public Person this[string name]
    {
        get
        {
            return Children.Find(p => p.Name == name);
        }
        set
        {
            Person found = Children.Find(p => p.Name == name);
            if (found is not null) found = value;
        }
    }
}

