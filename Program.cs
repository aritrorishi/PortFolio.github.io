// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static List<string> books = new List<string>();

    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Search for a Book");
            Console.WriteLine("4. Buy a Book");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ViewBooks();
                    break;
                case "3":
                    SearchBook();
                    break;
                case "4":
                    DelBook();
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Exiting the application...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Enter the book title: ");
        string title = Console.ReadLine();
        books.Add(title);
        Console.WriteLine($"Book '{title}' has been added.");
    }

    static void ViewBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available in the library.");
            return;
        }

        Console.WriteLine("Books in the Library:");
        foreach (var book in books)
        {
            Console.WriteLine($"- {book}");
        }
    }

    static void SearchBook()
    {
        Console.Write("Enter the book title to search: ");
        string searchTitle = Console.ReadLine();
        bool found = false;

        foreach (var book in books)
        {
            if (book.Contains(searchTitle, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Found: {book}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Book not found.");
        }
        
        
    }
    static void DelBook(){
        Console.Write("Enter the book title to buy: ");
        string title = Console.ReadLine();
        if (books.Contains(title)){
            books.Remove(title);
            Console.WriteLine($"Book '{title}' has been purchased.");
        }
        else{
            Console.WriteLine("Book not found.");
        }

    }
}

