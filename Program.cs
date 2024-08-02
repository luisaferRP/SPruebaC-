

using SimulacroPruebaC.models;

do
{
    InterfazVisual.Visual();
    int option;
    try
    {
        bool opSuccess = int.TryParse(Console.ReadLine(),out option);
    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("¡Ey! ¡Por favor ingresa un dato valido!");
        Console.ResetColor();
    }


    
} while (true);