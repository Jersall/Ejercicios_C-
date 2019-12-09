/*Ejercicio 4.4.4.2: Un programa que te pida tu nombre y lo muestre en pantalla como un
triángulo creciente.*/
using System;
public class E4_4_4_2
{
    public static void Ejecutar()
    {
        string nombre, subnombre;
        Console.Write("¿Nombre?: ");
        nombre = Convert.ToString(Console.ReadLine());
        int numerolargo = nombre.Length;
        for(int i = 0; i < numerolargo; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                subnombre = nombre.Substring(j, 1);
                if(j == i)
                {
                    Console.WriteLine(subnombre);
                }
                else
                {
                    Console.Write(subnombre);
                }
            }
        }
    }
}