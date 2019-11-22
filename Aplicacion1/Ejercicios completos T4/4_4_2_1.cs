/*Ejercicio 4.4.2.1:  Crea un programa que pregunte al usuario su nombre y le responda cuál
es su inicial.*/
using System;
public class E4_4_2_1
{
    public static void Ejecutar()
    {
        string nombre;
        Console.Write("¿Nombre?: ");
        nombre = Convert.ToString(Console.ReadLine());
        Console.WriteLine("{0} de {1}... interesante.", nombre[0], nombre);
    }
}
