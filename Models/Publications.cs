namespace Library.Models;

public abstract class Publication
{
    public string Title { get; set; }
    public int Year { get; set; }

    public Publication(string title, int year)
    {
        Title = title;
        Year = year;
    }

    public abstract string GetDescription();
}