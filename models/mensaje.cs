namespace SimulacroPruebaC.models
{
    public class mensaje
    {
        public static void MensageSuccesAdd(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Dato agregado de forma exitosa!");
            Console.ResetColor();
        }

        public static void MensageEliminarError(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡El dato no ha sido eliminado!");
            Console.ResetColor();
        }

        public static void MensageEliminarSucces(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Dato eliminado de forma exitosa!");
            Console.ResetColor();
        }

        



    }
}