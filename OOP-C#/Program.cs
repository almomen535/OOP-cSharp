using System.Security.Cryptography;

namespace OOP_C_
{


    class Author
    {
        public string name;
        public string email;
        public string nationality;

        public string GetDetails()
        {

            return $" Author:{name}\n Email:{email}\n Nationality: {nationality}";


        }
    }

    class Book
    {
        public string title;
        public string ISBN;
        public double price;

        public string GetBookInfo()
        {
            return $" Book Title: {title}\n ISBN:{ISBN}\n Price: {price}";
        }


        internal class Program
        {
            static void Main(string[] args)
            {

                Author p1 = new Author();
                p1.name = "J.K. Rowling";
                p1.email = "jkrowling@example.com";
                p1.nationality = "British";
                Console.WriteLine(p1.GetDetails());
            }
        }
    }
}
