using System.Xml;

namespace Example_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var population = 67_000_000; 
            var weight = 1.88; 
            var price = 4.99M; 
            var fruit = "Apples"; 
            var letter = 'Z'; 
            var happy = true;
            
            var xml1 = new XmlDocument(); 
            XmlDocument xml2 = new XmlDocument(); 
                                                  
            var file1 = File.CreateText("something.txt");
            StreamWriter file2 = File.CreateText("something.txt");


            file1.Write(); // can still access a File methods while declaring with var
            file2.Write();

            Console.WriteLine(fruit.Length);
            //Console.WriteLine(population.Length); // Doesn't work !
        }
    }
}
