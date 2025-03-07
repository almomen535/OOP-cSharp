namespace OOP_C_
{
    class Person
    {

        public string name;
        private int age;



        public void SetName(string n)
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
        }

        // Method-> DisplayInfo
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {GetName()} and Age: {GetAge()}\n");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            //Object-> p1
            Person p1 = new Person();
            p1.name = "Momen";
            p1.SetName("Al Momen");
            p1.SetAge(33);
            p1.DisplayInfo();


        }
    }

}
