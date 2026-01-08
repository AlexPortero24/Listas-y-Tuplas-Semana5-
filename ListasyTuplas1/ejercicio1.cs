//Ejercicio 1
//Escribir un programa que almacene las asignaturas de un curso (por ejemplo, Matemáticas, Física, Química, Historia y Lengua) en una lista y la muestre por pantalla.

using System;// Importa el espacio de nombres System para funcionalidades básicas
using System.Collections.Generic;// Importa el espacio de nombres System.Collections.Generic para utilizar listas genéricas

public class Ejercicio1// Define la clase del ejercicio
{
    public static void Ejecutar()// Método que será llamado desde Program.cs
    {
        List<string> asignaturas = new List<string>// Crea una lista de cadenas para almacenar las asignaturas
        {
            "ESTRUCTURA DE DATOS",
            "SISTEMAS OPERATIVOS",
            "SISTEMAS DIGITALES",
            "INSTALACIONES ELECTRICAS",
            "METODOLOGIA"
        };

        Console.WriteLine("Asignaturas del curso:");// Muestra las asignaturas del curso en la consola 
        foreach (string asignatura in asignaturas)// Itera a través de cada asignatura en la lista
        {
            Console.WriteLine("- " + asignatura);// Muestra cada asignatura en la consola
        }
    }
}// Fin de la clase Ejercicio1
