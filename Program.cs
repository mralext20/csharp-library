using System;
using System.Collections.Generic;
using library.Models;
namespace library
{
  class Program
  {
    static void Main(string[] args)
    {
      Library boise = new Library("boise", new List<Book>() {
          new Book("how to ride a bike", "someone not qualified"),
           new Book("Where the Sidewalk Ends", "Shel Silverstein"),
           new Book("docter pepper", "a coke brand"),
           new Book("the Hobbit", "J.R.R. Tolkien"),
           new Book("the lion the witch and wardrobe", "cs lewis"),
           new Book("Harry Potter and the sorcerrer's Stone", "J.K. Rowling")
        });
      while (true)
      {
        Console.Clear();

        Console.WriteLine($"welcone to the {boise.Name} Library!\n");
        System.Console.WriteLine(boise.GetBooks());
        bool invalidInput = false;
        do
        {
          invalidInput = false;

          Console.WriteLine("Select a book number to checkout, or (Q)uit or (R)eturn a book.");
          string input = Console.ReadLine().Trim().ToLower();
          if (input.StartsWith('q'))
          {
            return;
          }
          else if (input.StartsWith('r'))
          {
            Console.WriteLine("what book number?");
            boise.ReturnBook(Convert.ToInt32(Console.ReadLine().ToLower().Trim()));
          }
          else if (boise.validateBook(Convert.ToInt32(input)))
          {
            boise.CheckOut(Convert.ToInt32(input));
          }
          else
          {
            invalidInput = true;
          }
        } while (invalidInput);
      }
    }
  }
}
