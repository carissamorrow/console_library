﻿using System;
using System.Collections.Generic;

namespace console_library.Models
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      var library = new Library("Welcome to the Library!");
      Book sidewalk = new Book("Shel Silverstein", "Where the Sidewalk Ends");
      Book thisIsANewBook = new Book("Fake Author", "Fake Title");
      Book thisIsFakeBookTwo = new Book("Fake Author Two", "Fake Title Two");
      library.AddBook(sidewalk);
      library.AddBook(thisIsANewBook);
      library.AddBook(thisIsFakeBookTwo);

      Console.WriteLine(library.Name);
      library.PrintBooks();
      var inthelibrary = true;
      while (inthelibrary)
      {
        Console.WriteLine("Here are your options:");
        Console.WriteLine("1. Check out a book");
        Console.WriteLine("2. Return a book");
        Console.WriteLine("3. Leave Library");
        int choice;
        if (Int32.TryParse(Console.ReadLine(), out choice))
        {
          if (choice == 1)
          {
            library.Checkout();
          }
          else if (choice == 2)
          {
            // inthelibrary = true;
          }
          else if (choice == 3)
          {
            inthelibrary = false;
            Console.Clear();
            System.Console.WriteLine("Thanks for visiting.");
          }
        }
      }

    }
  }
}

