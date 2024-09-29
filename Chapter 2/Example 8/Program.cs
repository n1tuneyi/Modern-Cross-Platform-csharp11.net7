namespace Example_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double a = 0.1;
            //double b = 0.2;
            decimal a = 0.1M;
            decimal b = 0.2M;
            if(a + b == 0.3M)
                Console.WriteLine($"{a} + {b} = {0.3}");
            else
                Console.WriteLine($"{a} + {b} != {0.3}");
        }
    }
}
