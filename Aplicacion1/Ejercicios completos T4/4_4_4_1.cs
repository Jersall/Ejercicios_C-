/*Ejercicio 4.4.4.1: Un programa que te pida tu nombre y lo muestre en pantalla separando
cada letra de la siguiente con un espacio, similar al 4.4.3.1, pero esta vez usando
"Substring". Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla 
"J u a n"*/
using System;
public class E4_4_4_1
{
    public static void Ejecutar()
    {
        string nombre;
        string sub;
        Console.Write("¿Nombre?: ");
        nombre = Convert.ToString(Console.ReadLine());
        int longeo = nombre.Length;
        for(int i = 0; i < longeo; i++)
        {
            sub = nombre.Substring(i, 1);
            if (i < longeo - 1)
            {
                Console.Write(sub + " ");
            }
            else
            {
                Console.WriteLine(sub);
            }
        }
    }
}
