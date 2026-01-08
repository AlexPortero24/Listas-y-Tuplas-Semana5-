//Ejercicio 8
//Escribir un programa usando tuplas que pida al usuario una palabra y muestre por pantalla si es un palíndromo.

using System;// Importa el espacio de nombres System para funcionalidades básicas
using System.Collections.Generic;// Importa el espacio de nombres System.Collections.Generic para utilizar listas genéricas
using System.Linq;// Necesario para usar Reverse()

public class Ejercicio8// Define la clase del ejercicio
{
    public static void Ejecutar()// Método que será llamado desde Program.cs
    {
        Console.WriteLine("Introduce una palabra:");// Pide al usuario que introduzca una palabra
        string palabra = Console.ReadLine();// Lee la palabra desde la consola

        // Crear una tupla para almacenar la palabra y su estado de palíndromo
        var resultado = EsPalindromo(palabra);// Llama a la función para verificar si es un palíndromo
        Console.WriteLine($"La palabra '{resultado.Item1}' es un palíndromo: {resultado.Item2}");// Muestra el resultado en la consola
    }

    static (string, bool) EsPalindromo(string palabra)// Función que verifica si una palabra es un palíndromo
    {
        string palabraReversa = new string(palabra.Reverse().ToArray());// Invierte la palabra
        bool esPalindromo = palabra.Equals(palabraReversa, StringComparison.OrdinalIgnoreCase);// Compara la palabra original con la invertida, ignorando mayúsculas y minúsculas
        return (palabra, esPalindromo);// Devuelve una tupla con la palabra y el resultado de la verificación
    }
}// Fin de la clase Ejercicio8
