//Ejercicio 9
//Escribir un programa usando listas que pida al usuario una palabra y muestre por pantalla el número de veces que contiene cada vocal.

using System;// Importa el espacio de nombres System para funcionalidades básicas
using System.Collections.Generic;// Importa el espacio de nombres System.Collections.Generic para utilizar listas genéricas

public class Ejercicio9// Define la clase del ejercicio
{
    public static void Ejecutar()// Método que será llamado desde Program.cs
    {
        Console.WriteLine("Introduce una palabra:");// Pide al usuario que introduzca una palabra
        string palabra = Console.ReadLine();// Lee la palabra desde la consola

        // Crear un diccionario para contar las vocales
        Dictionary<char, int> contadorVocales = new Dictionary<char, int>
        {
            {'a', 0},// Inicializa el contador de la vocal 'a'
            {'e', 0},// Inicializa el contador de la vocal 'e'
            {'i', 0},// Inicializa el contador de la vocal 'i'
            {'o', 0},// Inicializa el contador de la vocal 'o'
            {'u', 0}// Inicializa el contador de la vocal 'u'
        };

        // Contar las vocales en la palabra
        foreach (char letra in palabra.ToLower())
        {
            if (contadorVocales.ContainsKey(letra))// Verifica si la letra es una vocal
            {
                contadorVocales[letra]++;// Incrementa el contador de la vocal correspondiente
            }
        }

        // Mostrar el resultado
        Console.WriteLine("Número de veces que contiene cada vocal:");// Muestra el encabezado del resultado
        foreach (var par in contadorVocales)// Itera a través de cada par clave-valor en el diccionario
        {
            Console.WriteLine($"{par.Key}: {par.Value}");// Muestra la vocal y su contador
        }
    }
}// Fin de la clase Ejercicio9
