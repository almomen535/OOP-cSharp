using System.Security.Cryptography;

namespace OOP_C_
{
    class Person
    {

        private string name;
        private int age;




        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

       /* public void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
        public void SetAge(int a)
        {
            age = a;
        }

        public int GetAge()
        {
            return age;
        }*/

        // Method-> DisplayInfo
        /*public void DisplayInfo()
        {
            Console.WriteLine($"Name: {p1.Age} and Age: {GetAge()}\n");
        }*/


    }

    class Program
    {
        static void Main(string[] args)
        {

            //Object-> p1
            Person p1 = new Person();
            p1.Name = "Momen";
            p1.Age=27;
            //p1.DisplayInfo();
            Console.WriteLine($"Name={p1.Name} and Age= {p1.Age}");

        }
    }

}
