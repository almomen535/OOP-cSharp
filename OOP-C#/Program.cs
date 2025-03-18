using System;
using System.Threading.Channels;
using System.Collections.Generic;
namespace OOP_C_
{


    abstract class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public int ID { get; set; }
     

        public abstract string GetDetails();
        
    }

     class Student : Person
    {

        public string RollNumber { get; set; }
        public string Department { get; set; }
        public double CGPA { get; set; }


        public Student(string name, string age,int id,string rollNumber, string department, double cGPA)

        {
            Name = name;
            RollNumber = rollNumber;
            Age = age;
            ID = id;
            Department = department;
            CGPA = cGPA;
        }

       
        public override string GetDetails()
        {
            
            return($"Student: {Name}, Age: {Age}, Roll: {RollNumber}, Department: {Department}, CGPA: {CGPA}");
        }

    }


    class Teacher : Person
    {
        public string Subject { get; set; }
        public string Salary { get; set; }


        public Teacher(string name, string age,int id,string subject, string salary) 
        {
            Name = name;
            Age = age;
            ID = id;
            Subject = subject;
            Salary = salary;
        }

        public override string GetDetails()
        {
            {
               
                return($"Teacher: {Name}, Age: {Age}, Subject: {Subject}, Salary: {Salary}");
            }
        }
    }



    // Management System Class
   
    class ManagementSystem
    {
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public void AddTeacher(Teacher t)
        {
            teachers.Add(t);
        }



        public void DisplayStudents()
        {
            Console.WriteLine("Students List: ");

            foreach(var i in students)
            {
                Console.WriteLine(i.GetDetails());
            }
        }


        public void DisplayTeachers()
        {
            Console.WriteLine("Teachers List: ");

            foreach( var i in teachers)
            {
                Console.WriteLine(i.GetDetails());
            }
        }

    }

    public class Myclass
    {
        static void Main(string[] args)
        {


            ManagementSystem ms = new ManagementSystem();


            Student student1 = new Student("Al Momen","24",1234,"CS210","CSE",3.50);
            Student student2 = new Student("Sakib", "20", 1211, "CS220", "EEE", 3.00);
            ms.AddStudent(student1);
            ms.AddStudent(student2);
            ms.DisplayStudents();

            Console.WriteLine(" ");

            Teacher teacher1 = new Teacher("Tanvir Islam", "29", 74933, "Networking","40,000 Taka ");
            Teacher teacher2 = new Teacher("Sayeduzzaman ", "36", 12008, "DSA", "60,000 Taka");
            ms.AddTeacher(teacher1);
            ms.AddTeacher(teacher2);
            ms.DisplayTeachers();
        }
    }
}
