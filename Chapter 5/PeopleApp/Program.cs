
using Packt.Shared;

Person bob = new();

Person? x = null;


bob.Name = "Bob Smith";

bob.DateOfBirth = new DateTime(1965, 12, 22);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;



//WriteLine(format: "{0}'s favorite wonder is {1}. Its integer is {2}.", arg0: bob.Name,
//          arg1: bob.FavoriteAncientWonder,
//          arg2: (int)bob.FavoriteAncientWonder);


Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};

//WriteLine(format: "{0} was born on {1:dd MMM yy}", arg0: alice.Name, arg1: alice.DateOfBirth);

bob.Children.Add(new Person { Name = "Alfred" }); 
bob.Children.Add(new() { Name = "Zoe" }); 

WriteLine($"{bob.Name} has {bob.Children.Count} children:");

foreach (Person p in bob.Children)
{
    WriteLine($"> {p.Name}");
}