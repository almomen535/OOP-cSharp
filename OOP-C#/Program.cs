using System.Security.Cryptography;

namespace OOP_C_
{


    class Author
    {
       public string name;
       public string email;
       public string nationality;

        public void GetDetails()
        {
            Console.WriteLine($"Author: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Nationality: {nationality}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Author p1 = new Author();
            p1.name= "J.K. Rowling";
            p1.email = "jkrowling@example.com";
            p1.nationality = "British";
            p1.GetDetails();


        }
    }
}
