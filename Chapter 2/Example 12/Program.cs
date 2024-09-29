Person person = new();

person.FirstName = "Youssef";

List<Person> persons = new()
{
    new() {FirstName = "Mohamed"},
    new() {FirstName = "Mostafa"}
};


class Person
{
    public String FirstName;
}
