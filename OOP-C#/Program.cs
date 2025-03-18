using System;
using System.Threading.Channels;
namespace OOP_C_
{


    abstract class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public int ID { get; set; }


        public Person(string name, string age, int id)
        {
            Name = name;
            Age = age;
            ID = id;
        }

        public abstract void GetDetails();
        
    }

     class Student : Person
    {

        public string RollNumber { get; set; }
        public string Department { get; set; }
        public double CGPA { get; set; }


        public Student(string name, string age,int id,string rollNumber, string department, double cGPA)
               : base(name,age,id)     // Student Constructor calling Person Constructor
        {
            RollNumber = rollNumber;
            Department = department;
            CGPA = cGPA;
        }

       
        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nRoll: {RollNumber}\nDepartment: {Department}\nCGPA: {CGPA}");
        }

    }


    public class Myclass
    {
        static void Main(string[] args)
        {   

            Student student1 = new Student("Al Momen","24",1234,"CS210","CSE",3.50);
            student1.GetDetails();
        }
    }
}
