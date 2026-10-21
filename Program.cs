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

Console.Write("Mostrar publicaciones posteriores al año: ");
var input = Console.ReadLine();

if (int.TryParse(input, out int decision))
{
    foreach (var publication in allPublications)
    {
        if (publication.Year > decision)
        {
            Console.WriteLine(publication.GetDescription());
        }
    }
} else
{
    Console.WriteLine("Debe introducir un número entero.");    
}