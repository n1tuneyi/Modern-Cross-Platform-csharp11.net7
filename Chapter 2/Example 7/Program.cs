namespace Example_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int size: {sizeof(int)} the range is {int.MinValue:N0} to {int.MaxValue:N0}");
            Console.WriteLine($"float size: {sizeof(float)} the range is {float.MinValue:N0} to {float.MaxValue:N0}");
            Console.WriteLine($"Double size: {sizeof(Double)} the range is {Double.MinValue} to {Double.MaxValue}");
            Console.WriteLine($"Decimal size: {sizeof(Decimal)} the range is {Decimal.MinValue:N0} to {Decimal.MaxValue:N0}");
        }
    }
}
