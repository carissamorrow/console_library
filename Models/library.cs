using System;
using System.Collections.Generic;

namespace console_library.Models
{
  public class Library
  {
    public string Name { get; private set; }
    private List<Book> Books { get; set; }
    public Library(string name)
    {
      Name = name;
      Books = new List<Book>();

    }
    public void AddBook(Book book)
    {
      Books.Add(book);
    }

    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        System.Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }
    }
    public void Checkout()
    {
      Console.Clear();
      PrintBooks();
      System.Console.WriteLine("What book do you want to checkout?");
      string selection = Console.ReadLine();
      int index;
      if (Int32.TryParse(selection, out index) == false)
      {
        Console.WriteLine("Not a valid choice, enter a valid choice");
      }
      Book targetBook = Books[index - 1];
      if (targetBook == null)
      {
        Console.WriteLine("Not a valid selection");
      }
      if (!targetBook.Available)
      {
        Console.WriteLine($"{targetBook.Title} is not available, choose another");
      }
      targetBook.Available = false;
      Console.WriteLine($"Thanks for Checking out {targetBook.Title}.");
    }
    public void ReturnBook()
    {
      Console.Clear();
      PrintBooks();
      System.Console.WriteLine("Thank you for returning the book");
      string selection = Console.ReadLine();
      int index;
      if (Int32.TryParse(selection, out index) == false)
      {
        Console.WriteLine("Not a valid choice, enter a valid choice");
      }
      Book targetBook = Books[index - 1];
      if (!targetBook.Available)
      {
        targetBook.Available = true;
        // Checkout.Remove(targetBook);
        Console.WriteLine($"Thanks for returning {targetBook.Title}.");
      }

    }

  }
}