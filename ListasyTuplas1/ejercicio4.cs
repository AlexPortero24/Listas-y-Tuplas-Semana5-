//Ejercicio 4
//Escribir un programa que pregunte al usuario los números ganadores de la lotería primitiva, los almacene en una lista y los muestre por pantalla ordenados de menor a mayor.

using System;// Importa el espacio de nombres System para funcionalidades básicas
using System.Collections.Generic;// Importa el espacio de nombres System.Collections.Generic para utilizar listas genéricas

public class Ejercicio4// Define la clase del ejercicio
{
    public static void Ejecutar()// Método que será llamado desde Program.cs
    {
        List<int> numerosGanadores = new List<int>();   // Crea una lista de enteros para almacenar los números ganadores 

        Console.WriteLine("Introduce los números ganadores de la lotería primitiva (0 para finalizar):"); // Pide al usuario que introduzca los números ganadores         
        int numero; // Variable para almacenar el número introducido por el usuario
        while (true) // Bucle infinito para leer números hasta que el usuario decida finalizar
        {
            numero = int.Parse(Console.ReadLine());// Lee un número desde la consola y lo convierte a entero
            if (numero == 0) break;// Si el número es 0, sale del bucle
            numerosGanadores.Add(numero);// Añade el número a la lista de números ganadores
        }

        numerosGanadores.Sort();// Ordena la lista de números ganadores de menor a mayor

        Console.WriteLine("Números ganadores (ordenados):");// Muestra los números ganadores ordenados en la consola
        foreach (int n in numerosGanadores)// Itera a través de cada número en la lista
        {
            Console.WriteLine(n);// Muestra cada número en la consola
        }// Fin del bucle foreach
    }
}// Fin de la clase Ejercicio4
