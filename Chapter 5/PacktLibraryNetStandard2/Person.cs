﻿using System.Xml.Linq;

namespace Packt.Shared;

public class Person: object
{
    public string? Name;

    public DateTime DateOfBirth;

    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public WondersOfTheAncientWorld BucketList;

    public List<Person> Children = new();

    public const string Species = "Homo Sapiens";

    public readonly string HomePlanet = "Earth";

    public readonly DateTime Instantiated;

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
}

