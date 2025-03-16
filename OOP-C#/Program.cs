
using System.Globalization;
using System.Threading.Tasks.Dataflow;

namespace OOP_C_
{


    class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }


        public Author(string name, string email, string nationality)
        {
            Name = name;
            Email = email;
            Nationality = nationality;
        }

        public string GetDetails()
        {

            return $" Author:{Name}\n Email:{Email}\n Nationality: {Nationality}";

        }
    }

    class Book
    {
        public string Title { get; set; }
        public string ISBN {  get; set; }
        public double Price { get; set; }
        public Author BookAuthor { get; set; } //BookAuthor is a reference variable. It holds a reference (or pointer) to an object of the Author class.
        public List<string> Genres { get; set; }


        public Book(string title, string isbn, double price, Author bookauthor, List<string> genres)
        {
            Title = title;
            ISBN = isbn;
            Price = price;
            BookAuthor = bookauthor;       // Linked  
            Genres = genres;
           
        }

        public string GetBookInfo()
        {
            return $" Book Title: {Title}\n ISBN:{ISBN}\n Price: ${Price}\n Genres:{string.Join(",",Genres)}\n{BookAuthor.GetDetails()}\n";
        }

    }

        internal class Program
        {
            static void Main(string[] args)
            {

                Author author1 = new Author("J.K. Rowling", "jkrowling@example.com", "British");
                Author author2 = new Author("George Orwell", "george@example.com", "British");


                List<string> genres1 = new List<string> { "Fiction", "Non-Fiction", "Sci-Fi" };
                List<string> genres2 = new List<string> { "Commercial", "Non-commercial" };
                List<string> genres3 = new List<string> { "Milkway Galaxy", "X515", "X00Af" };

                Book book1 = new Book("Harry Potter", "123-4567890123", 19.99,author1,genres1);
                Book book2 = new Book("Animal Farm", "345-6789012345", 12.99,author2,genres2);
                Book book3 = new Book("Galaxy", "234-5678901234", 14.99, author1, genres3);

                


                Console.WriteLine(book1.GetBookInfo());
                Console.WriteLine(book2.GetBookInfo());
                Console.WriteLine(book3.GetBookInfo());

        }
        }
    }

