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

GetPublications(allPublications);
GetPublicationsAfterYear(allPublications);

static void GetPublications(List<Publication> allPublications)
{
    Console.WriteLine("LISTADO DE PUBLICACIONES");
    foreach (var publication in allPublications)
    {
        Console.WriteLine(publication.GetDescription());
    }
}

static void GetPublicationsAfterYear(List<Publication> allPublications)
{
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
    }
    else
    {
        Console.WriteLine("Debe introducir un número entero.");
    }
}