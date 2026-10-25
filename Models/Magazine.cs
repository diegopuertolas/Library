namespace Library.Models;

public class Magazine : Publication
{
    public int Number { get; set; }

    public Magazine(string title, int year, int number)
        : base(title, year)
    {
        Number = number;
    }

    public override string GetDescription()
    {
        return $"{Title} | {Year} | {Number}";
    }
}