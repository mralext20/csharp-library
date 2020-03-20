using System.Collections.Generic;
using System.Collections;
using System;

namespace library.Models
{
  class Library
  {
    public string Name { get; set; }
    private List<Book> _books { get; set; } = new List<Book>();

    public Library(string name)
    {
      Name = name;
    }

    public Library(string name, IEnumerable<Book> books)
    {
      _books.AddRange(books);
    }

    public string GetBooks()
    {
      string template = "";

      for (int i = 0; i < _books.Count; i++)
      {
        Book current = _books[i];
        template = $"{template}{i + 1}. {current.Title}, by {current.Author}. {(current.Avalible ? "" : "Not ")}Currently Avalible.\n";
      }
      return template;
    }

    internal bool validateBook(int v)
    {
      return _books.Count >= v && _books[v - 1].Avalible;
    }

    internal void CheckOut(int v)
    {
      _books[v - 1].Avalible = false;
    }

    internal void ReturnBook(int v)
    {
      _books[v - 1].Avalible = true;
    }
  }
}