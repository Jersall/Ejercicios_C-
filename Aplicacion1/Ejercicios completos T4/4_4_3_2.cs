/*Ejercicio 4.4.3.2:  Un programa que pida una frase al usuario y la muestra en orden inverso
(de la última letra a la primera).*/
using System;
public class E4_4_3_2
{
    public static void Ejecutar()
    {
        string frase;
        Console.Write("¿Frase?: ");
        frase = Convert.ToString(Console.ReadLine());
        for(int i = frase.Length - 1; i >= 0; i--)
        {
            Console.Write(frase[i]);
        }
    }
}