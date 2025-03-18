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
            Console.WriteLine($"Students Informaton:\n");
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nRoll: {RollNumber}\nDepartment: {Department}\nCGPA: {CGPA}");
        }

    }


    class Teacher : Person
    {
        public string Subject { get; set; }
        public string Salary { get; set; }


        public Teacher(string name, string age,int id,string subject, string salary) : base(name, age, id)  // Calling Person COnstructor
        {
            Subject = subject;
            Salary = salary;
        }

        public override void GetDetails()
        {
            {
                Console.WriteLine($"Teachers Informaton:\n");
                Console.WriteLine($"Name: {Name}\nAge: {Age}\nSubject: {Subject}\nSalary: {Salary}");
            }
        }
    }

    public class Myclass
    {
        static void Main(string[] args)
        {   

            Student student1 = new Student("Al Momen","24",1234,"CS210","CSE",3.50);
            student1.GetDetails();

            Console.WriteLine(" ");

            Teacher teacher1 = new Teacher("Tanvir Islam", "29", 74933, "Networking","40,000 $");
            teacher1.GetDetails();
        }
    }
}
