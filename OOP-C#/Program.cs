namespace OOP_C_
{
    /* class Person
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
         }*/
    //}



    class Person
    {
        // Using 2 field-> name and age
        public string name;
        public int age;



        /* 
         
         Constructor: A special method which is used for Initialize the object's value and it is exactly the same name of the class.
         In this case, the class is Person. A normal method works when it is called, but there is no need to call
         the constructor. The constructor will be called instantly when an object is created.
        
         */

        public Person(string n, int a)  // Parameterized Constructor
        {
            name = n;
            age = a;
        }

        public Person()
        {
            name = "Test";
            age = 15;
        }


        // Method-> DisplayInfo
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name} and Age: {age}\n");
        }


        /*//Method-> SetValue
        public void SetValue(string n,int a)
         {
            name = n;
           age = a;
        }*/


    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //Object-> p1
            Person p1 = new Person("Al Momen", 24);
            p1.DisplayInfo();



            // Object-> p2
            Person p2 = new Person("Muntasir Asif", 25);
            p2.DisplayInfo();


            //Object-> 3
            Person p3 = new Person();
            Console.WriteLine("This is default constructor example below:  ");
            p3.DisplayInfo();

        }
    }
}
