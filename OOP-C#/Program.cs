namespace OOP_C_
{
    class Person
    {
        public string name;
        public int age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.name = "Al Momen";
            p1.age = 24;
            Console.WriteLine("Person1:");
            Console.WriteLine($"Name: {p1.name},Age: {p1.age}");


            Person p2 = new Person();
            p2.name = "Samiul Islam";
            p2.age = 26;
            Console.WriteLine("Person2: ");
            Console.WriteLine($"Name: {p2.name}, Age: {p2.age}");
        }
    }
}
