namespace Example_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new { FirstName = "Alice", Age = 56 };
            string json = $$"""
                            
                            "first_name": "{{person.FirstName}}",
                            "age": {{person.Age}},
                            "calculation", "{{{1 + 2}}}"
                            
                            """;
                Console.WriteLine(json);
        }
    }
}
