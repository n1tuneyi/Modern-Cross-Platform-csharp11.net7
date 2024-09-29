namespace Third_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = [1, 2, 3];
            Console.WriteLine(list.Where(num => num == 2).First());
        }
    }
}
