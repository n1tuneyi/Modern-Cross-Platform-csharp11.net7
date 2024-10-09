﻿
using Packt.Shared;
using System.Threading;

Person bob = new();

Person? x = null;


bob.Name = "Bob Smith";

bob.DateOfBirth = new DateTime(1965, 12, 22);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;



//WriteLine(format: "{0}'s favorite wonder is {1}. Its integer is {2}.", arg0: bob.Name,
//          arg1: bob.FavoriteAncientWonder,
//          arg2: (int)bob.FavoriteAncientWonder);


//Person alice = new()
//{
//    Name = "Alice Jones",
//    DateOfBirth = new(1998, 3, 7)
//};

//WriteLine(format: "{0} was born on {1:dd MMM yy}", arg0: alice.Name, arg1: alice.DateOfBirth);

//bob.Children.Add(new Person { Name = "Alfred" }); 
//bob.Children.Add(new() { Name = "Zoe" }); 

//WriteLine($"{bob.Name} has {bob.Children.Count} children:");

//foreach (Person p in bob.Children)
//{
//    WriteLine($"> {p.Name}");
//}


BankAccount.InterestRate = 0.012M;
BankAccount jonesAccount = new();

jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

//WriteLine(format: "{0} earned {1:C} interest.",arg0: jonesAccount.AccountName, 
//          arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

//WriteLine(format: "{0} earned {1:C} interest.", arg0: gerrierAccount.AccountName,
//          arg1: gerrierAccount.Balance * BankAccount.InterestRate);

Person blankPerson = new();
//WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.", arg0: blankPerson.Name,
//          arg1: blankPerson.HomePlanet,
//          arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.", arg0: gunny.Name, arg1: gunny.HomePlanet,
arg2: gunny.Instantiated);

//bob.WriteToConsole();

//WriteLine(bob.GetOrigin());

//(string, int) fruit = bob.GetFruit();

//WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

//var fruitNamed = bob.GetNamedFruit();

//WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

//var thing1 = ("Neville", 4);
//WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

//var thing2 = (bob.Name, bob.Children.Count);
//WriteLine($"{thing2.Name} has {thing2.Count} children.");


//(string fruitName, int fruitNumber) = bob.GetFruit();

//WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

var (name1, dob1) = bob;

//WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;

//WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");


//WriteLine(bob.OptionalParameters());

//WriteLine(bob.OptionalParameters("Jump!", 98.5));

//WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));

//WriteLine(bob.OptionalParameters("Poke!", active: false));

int a = 10;
int b = 20;
int c = 30;

//WriteLine($"Before: a = {a}, b = {b}, c = {c}");

bob.PassingParameters(a, ref b, out c);

//WriteLine($"After: a = {a}, b = {b}, c = {c}");


Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1969, 6, 25)
};

//WriteLine(sam.Origin);

//WriteLine(sam.Greeting);

//WriteLine(sam.Age);


sam.FavoriteIceCream = "Chocolate Fudge";
//WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
//string color = "Red";

//try
//{
//    sam.FavoritePrimaryColor = color;
//    WriteLine($"Sam's favorite primary color is {sam.
//    FavoritePrimaryColor}.");
//}
//catch (Exception ex)
//{
//    WriteLine("Tried to set {0} to '{1}': {2}",
//    nameof(sam.FavoritePrimaryColor), color, ex.Message);
//}


//Book book = new()
//{
//    Isbn = "978-1803237800",
//    Title = "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals"
//};

Book book = new(isbn: "978-1803237800", title: "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J. Price",
    PageCount = 821
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages.", book.Isbn, book.Title, book.Author, book.PageCount);

sam.Children.Add(new()
{
    Name = "Charlie",
    DateOfBirth = new(2010, 3, 18)
});

sam.Children.Add(new()
{
    Name = "Ella",
    DateOfBirth = new(2020, 12, 24)
});


//WriteLine($"Sam's first child is {sam.Children[0].Name}.");
//WriteLine($"Sam's second child is {sam.Children[1].Name}.");

//WriteLine($"Sam's first child is {sam[0].Name}.");

//WriteLine($"Sam's second child is {sam[1].Name}.");

//WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");


//Person lamech = new() { Name = "Lamech" };
//Person adah = new() { Name = "Adah" };
//Person zillah = new() { Name = "Zillah" };

//lamech.Marry(adah);

//if (zillah + lamech)
//{
//    WriteLine($"{zillah.Name} and {lamech.Name} successfully got married.");
//}
////Person.Marry(zillah, lamech);

//WriteLine($"{lamech.Name} is married to {lamech.Spouse?.Name ?? "nobody"}");
//WriteLine($"{adah.Name} is married to {adah.Spouse?.Name ?? "nobody"}");
//WriteLine($"{zillah.Name} is married to {zillah.Spouse?.Name ?? "nobody"}");

//Person baby1 = lamech.ProcreateWith(adah);

//baby1.Name = "Jabal";
//WriteLine($"{baby1.Name} was born on {baby1.DateOfBirth}");

//Person baby2 = Person.Procreate(zillah, lamech);

//Person baby3 = lamech * adah;
//baby3.Name = "Jubal";

//Person baby4 = zillah * lamech;
//baby4.Name = "Naamah";


//baby2.Name = "Tubalcain";
//WriteLine($"{lamech.Name} has {lamech.Children.Count} children.");
//WriteLine($"{adah.Name} has {adah.Children.Count} children.");
//WriteLine($"{zillah.Name} has {zillah.Children.Count} children.");
//for (int i = 0; i < lamech.Children.Count; i++)
//{
//    WriteLine(format: "{0}'s child #{1} is named \"{2}\".",
//    arg0: lamech.Name, arg1: i, arg2: lamech[i].Name);
//}

//int number = -1; 

//try
//{
//    WriteLine($"{number}! is {Person.Factorial(number)}");
//}
//catch (Exception ex)
//{
//    WriteLine($"{ex.GetType().Name} says: {ex.Message} number was {number}.");
//}

Passenger[] passengers = [
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
    new BusinessClassPassenger { Name = "Janice" },
    new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" },
];

foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger _ => 2000M,
        BusinessClassPassenger _ => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}