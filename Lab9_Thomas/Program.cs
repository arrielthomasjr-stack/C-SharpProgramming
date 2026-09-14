using System;
using Library.Models;

class Program
{
    static void Main()
    {
        Book b1 = new Book
        {
            Title = "Introduction to Algorithms",
            BookAuthor = new Author { Name = "Thomas Cormen", Country = "USA" },
            Price = 89.99m
        };

        Book b2 = new Book
        {
            Title = "Clean Code",
            BookAuthor = new Author { Name = "Robert Martin", Country = "USA" },
            Price = 42.50m
        };

        Book b3 = new Book
        {
            Title = "The Pragmatic Programmer",
            BookAuthor = new Author { Name = "David Thomas", Country = "UK" },
            Price = 39.99m
        };

        LibraryCatalog catalog = new LibraryCatalog
        {
            Books = new Book[] { b1, b2, b3 }
        };

        catalog.DisplayAll();


    }
}