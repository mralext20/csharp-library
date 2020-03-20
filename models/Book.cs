namespace library.Models
{
  class Book
  {
    public string Title { get; }
    public string Author { get; }
    public bool Avalible { get; set; } = true;
    public Book(string title, string author)
    {
      Title = title;
      Author = author;
    }
  }
}