namespace Example_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1;
            double b = 0.2;
            if(a + b == 0.3)
                Console.WriteLine($"{a} + {b} = {0.3}");
            else
                Console.WriteLine($"{a} + {b} != {0.3}");
        }
    }
}
