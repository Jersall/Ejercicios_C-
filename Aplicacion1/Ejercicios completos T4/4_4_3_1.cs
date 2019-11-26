/*Ejercicio 4.4.3.1:  Un programa que te pida tu nombre y lo muestre en pantalla separando
cada letra de la siguiente con un espacio. Por ejemplo, si tu nombre es "Juan",
debería aparecer en pantalla "J u a n".*/
using System;
public class E4_4_3_1
{
    public static void Ejecutar()
    {
        string nombre;
        Console.Write("¿Nombre?: ");
        nombre = Convert.ToString(Console.ReadLine());
        int letras = nombre.Length;
        for (int i = 0; i < letras; i++)
        {
            if(i < letras - 1)
            {
                Console.Write("{0} ", nombre[i]);
            }
            else
            {
                Console.Write("{0}.", nombre[i]);
            }
        }
    }
}
