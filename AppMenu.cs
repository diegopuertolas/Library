using Library.Models;

public static class AppMenu
{
    public static void DisplayMenu(List<Publication> publications)
    {
        var option = -1;

        do
        {
            ShowMenu();
            option = ChooseOption();

            switch (option)
            {
                case 1:
                    Console.WriteLine();
                    ShowPublications(publications);
                    break;
                case 2:
                    Console.WriteLine();
                    SearchPublicationsAfterYear(publications);
                    break;
                case 0:
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\nOpción no válida. Introduzca un número del 0 al 2");
                    break;
            }

        } while (option != 0);
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n=== BIBLIOTECA ===");
        Console.WriteLine("1. Mostrar todas las publicaciones");
        Console.WriteLine("2. Mostrar publicaciones posteriores a un año concreto");
        Console.WriteLine("0. Salir");
    }

    public static int ChooseOption()
    {
        Console.Write("Elija una opción: ");
        var input = Console.ReadLine();
        
        if (!int.TryParse(input, out var decision))
        {
            Console.WriteLine("\nOpción incorrecta");
            return -1;
        }

        return decision;
    }

    public static void ShowPublications(List<Publication> publications)
    {
        foreach (var publication in publications)
        {
            Console.WriteLine(publication.GetDescription());
        }
    }

    public static void SearchPublicationsAfterYear(List<Publication> publications)
    {
        Console.Write("Mostrar publicaciones posteriores al año: ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out var decision))

        if (decision <= 0)
        {
            Console.WriteLine("\nLa publicación no puede pertener a un año inferior o igual a 0.");
            return;
        }

        var found = false;

        Console.WriteLine();
        foreach(var publication in publications)
        {
            if (decision <= publication.Year)
            {
                Console.WriteLine(publication.GetDescription());
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"No se han encontrado publicaciones anteriores al año: {decision}");
        }
    }
}