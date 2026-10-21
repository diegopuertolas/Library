using Library.Models;

var quijote = new Book("Don Quijote de la Mancha", 1563, "Miguel de Cervantes");
var hola = new Magazine("HOLA", 2010, 321);
var spiderman = new Comic("Spiderman", 1989, "Peter Lim");

var allPublications = new List<Publication>
{
    quijote, 
    hola,
    spiderman
};

foreach (var publication in allPublications)
{
    Console.WriteLine(publication.GetDescription());
}