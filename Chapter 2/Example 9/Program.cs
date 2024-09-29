namespace Example_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object height = 1.73; 
            object name = "Youssef"; 
            Console.WriteLine($"{name} is {height} metres tall.");
            //int length1 = name.Length; Object type doesn't have property Length 
            int length2 = ((string)name).Length;  // Here we can access Length after casting to string
            Console.WriteLine($"{name} has {length2} characters.");
        }
    }
}
