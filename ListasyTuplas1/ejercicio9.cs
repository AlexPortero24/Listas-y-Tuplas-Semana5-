//Ejercicio 9
//Escribir un programa que pida al usuario una palabra y muestre por pantalla el número de veces que contiene cada vocal.

using System; // Permite usar funcionalidades básicas de C#, como la consola
using System.Collections.Generic; // Permite usar listas genéricas en C#

public class Ejercicio9 // Define la clase del ejercicio
{
    public static void Ejecutar() // Método principal de la clase que se ejecuta desde Program.cs
    {
        Console.WriteLine("Introduce una palabra:"); // Solicita al usuario que ingrese una palabra
        string palabra = Console.ReadLine().ToLower(); // Lee la palabra ingresada y la convierte a minúsculas

        // Crear una lista con las vocales para comparar con las letras de la palabra
        List<char> vocales = new List<char> { 'a', 'e', 'i', 'o', 'u' };

        // Crear una lista de contadores inicializados en 0, uno por cada vocal
        List<int> contador = new List<int> { 0, 0, 0, 0, 0 };

        // Recorrer cada letra de la palabra
        foreach (char letra in palabra)
        {
            int index = vocales.IndexOf(letra); // Buscar si la letra es una vocal y obtener su posición en la lista
            if (index != -1) // Si la letra es una vocal (IndexOf devuelve -1 si no la encuentra)
            {
                contador[index]++; // Incrementa el contador correspondiente a esa vocal
            }
        }

        // Mostrar en la consola cuántas veces aparece cada vocal
        Console.WriteLine("Número de veces que contiene cada vocal:");
        for (int i = 0; i < vocales.Count; i++) // Recorrer cada vocal en la lista
        {
            Console.WriteLine($"{vocales[i]}: {contador[i]}"); // Mostrar la vocal y su contador
        }
    }
}

