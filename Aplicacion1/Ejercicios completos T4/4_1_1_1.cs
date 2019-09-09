/*Ejercicio 4.1.1.1: Programa que pide al usuario 4 numeros, los memorice en array 
y calcule su media aritmética, mostrando tanto la media como los datos tecleados.*/
using System;
public class Ejercicio4_1_1_1
{
    public static void Ejecutar()
    {
        int[] allN = new int[4];
        int media;
        Console.Write("¿Numero 1?: ");
        allN[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Numero 2?: ");
        allN[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Numero 3?: ");
        allN[2] = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Numero 4?: ");
        allN[3] = Convert.ToInt32(Console.ReadLine());
        media = (allN[0] + allN[1] + allN[2] + allN[3]) / 4;
        Console.WriteLine("Datos: {0}, {1}, {2}, {3}", allN[0], allN[1], allN[2], allN[3]);
        Console.Write("la media de estos numeros es:");
        Console.WriteLine(media);
    }
}

