namespace Library.Models;

public class Book : Publication
{
    public string Author { get; set; }

    public Book(string title, int year, string author)
        : base(title, year)
    {
        Author = author;
    }

    public override string GetDescription()
    {
        return $"{Title} | {Year} | {Author}";
    }
}