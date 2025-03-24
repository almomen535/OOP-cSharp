namespace OOP_C_
{     


    abstract class Team
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public abstract string GetDetalis();
      
    }

    public class Hexclan
    {
        public string Owner { get; set; }
        public string Captain { get; set; }



    }






    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
