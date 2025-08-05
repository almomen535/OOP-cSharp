
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
    public class Myclass
    {
        static void Main(string[] args)
        {
          
        }
    }

