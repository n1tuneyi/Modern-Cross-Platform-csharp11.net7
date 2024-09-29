namespace Example_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = "Youssef";

            //obj = 30;

            // Not safe because we don't know at runtime if obj is guaranteed to have Length property
            Console.WriteLine($"Length is {obj.Length}");

        }
    }
}
