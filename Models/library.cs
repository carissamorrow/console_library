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
    public void Checkout(Book selection)
    {
      Books.Add(selection);
    }

  }
}