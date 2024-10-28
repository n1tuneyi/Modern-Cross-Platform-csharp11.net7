﻿using Packt.Shared;
using static System.Environment;
using static System.IO.Path;
using FastJson = System.Text.Json.JsonSerializer;

List<Person> people = new()
{
    new(30000M)
    {
        FirstName = "Alice",
        LastName = "Smith",
        DateOfBirth = new(year: 1974, month: 3, day: 14)
    },
    new(40000M)
    {
        FirstName = "Bob",
        LastName = "Jones",
        DateOfBirth = new(year: 1969, month: 11, day: 23)
    },
    new(20000M)
    {
        FirstName = "Charlie",
        LastName = "Cox",
        DateOfBirth = new(year: 1984, month: 5, day: 4),
        Children = new()
        {
            new Person(0M)
            {
                FirstName = "Sally",
                LastName = "Cox",
                DateOfBirth = new(year: 2012, month: 7, day: 12)
            }
        }
    }
};

//XmlSerializer xs = new(type: people.GetType());

//string path = Combine(CurrentDirectory, "people.xml");
//using (FileStream stream = File.Create(path))
//{

//    xs.Serialize(stream, people);
//}
//WriteLine("Written {0:N0} bytes of XML to {1}", arg0: new FileInfo(path).Length,
//                                                arg1: path);
//WriteLine();

//WriteLine(File.ReadAllText(path));


//WriteLine();
//WriteLine("* Deserializing XML files");
//using (FileStream xmlLoad = File.Open(path, FileMode.Open))
//{

//    List<Person>? loadedPeople = xs.Deserialize(xmlLoad) as List<Person>;
//    if (loadedPeople is not null)
//    {
//        foreach (Person p in loadedPeople)
//        {
//            WriteLine("{0} has {1} children.",
//            p.LastName, p.Children?.Count ?? 0);
//        }
//    }
//}


string jsonPath = Combine(CurrentDirectory, "people.json");
using (StreamWriter jsonStream = File.CreateText(jsonPath))
{

    Newtonsoft.Json.JsonSerializer jss = new();

    jss.Serialize(jsonStream, people);
}

WriteLine();
WriteLine("Written {0:N0} bytes of JSON to: {1}",
arg0: new FileInfo(jsonPath).Length, arg1: jsonPath);

WriteLine(File.ReadAllText(jsonPath));

WriteLine();
WriteLine("* Deserializing JSON files");
using (FileStream jsonLoad = File.Open(jsonPath, FileMode.Open))
{
    List<Person>? loadedPeople = await FastJson.DeserializeAsync(utf8Json: jsonLoad,
                                returnType: typeof(List<Person>)) as List<Person>;
    if (loadedPeople is not null)
    {
        foreach (Person p in loadedPeople)
        {
            WriteLine("{0} has {1} children.",
            p.LastName, p.Children?.Count ?? 0);
        }
    }
}