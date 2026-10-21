namespace Library.Models;

public class Comic : Publication
{
    public string Cartoonist { get; set; }

    public Comic(string title, int year, string cartoonist)
        : base(title, year)
    {
        Cartoonist = cartoonist;
    }

    public override string GetDescription()
    {
        return $"{Title} | {Year} | {Cartoonist}";
    }
}