//Ejercicio 5
//Escribir un programa usando tuplas que almacene en una lista los números del 1 al 10 y los muestre por pantalla en orden inverso separados por comas.

using System;// Importa el espacio de nombres System para funcionalidades básicas
using System.Collections.Generic;// Importa el espacio de nombres System.Collections.Generic para utilizar listas genéricas

public class Ejercicio5   // Define la clase del ejercicio
{
    public static void Ejecutar() // Método que será llamado desde Program.cs
    {
        List<(int, string)> numeros = new List<(int, string)>();// Crea una lista de tuplas para almacenar los números y sus representaciones en cadena

        for (int i = 1; i <= 10; i++)// Bucle para agregar los números del 1 al 10 a la lista
        {
            numeros.Add((i, "Número " + i));// Añade una tupla con el número y su representación en cadena a la lista
        }

        Console.WriteLine("Números del 1 al 10 en orden inverso:");// Muestra los números en orden inverso en la consola
        for (int i = numeros.Count - 1; i >= 0; i--)// Bucle para mostrar los números en orden inverso
        {
            Console.Write(numeros[i].Item2);// Muestra la representación en cadena del número
            if (i > 0) Console.Write(", ");// Añade una coma y un espacio si no es el último número
        }
    }
}// Fin de la clase Ejercicio5
