using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione un ejercicio:");
        Console.WriteLine("1. Ejercicio 1");
        Console.WriteLine("4. Ejercicio 4");
        Console.WriteLine("5. Ejercicio 5");
        Console.WriteLine("8. Ejercicio 8");
        Console.WriteLine("9. Ejercicio 9");

        Console.Write("Opción: ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1": Ejercicio1.Ejecutar(); break;
            case "4": Ejercicio4.Ejecutar(); break;
            case "5": Ejercicio5.Ejecutar(); break;
            case "8": Ejercicio8.Ejecutar(); break;
            case "9": Ejercicio9.Ejecutar(); break;
            default: Console.WriteLine("Opción no válida"); break;
        }
    }
}
