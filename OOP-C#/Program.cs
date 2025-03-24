namespace OOP_C_
{     


    abstract class Team
    {
        public string Name { get; set; }

        abstract string GetDetalis();
      
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
