using System;
using System.Threading.Channels;
namespace OOP_C_
{


    public class Student
    {
        private string name;
        private string rollNumber;
        private DateTime dateOfBirth;
         
        public Student(string name, string rollNumber, DateTime dateOfBirth)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.dateOfBirth = dateOfBirth;
        }
        
    }
    public class Myclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}
