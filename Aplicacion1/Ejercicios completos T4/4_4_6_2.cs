/*Ejercicio 4.4.6.2: Un programa que pida al usuario una frase y elimine todos los espacios
redundantes que contenga (debe quedar sólo un espacio entre cada palabra y la siguiente).*/
using System;
public class E4_4_6_2
{
    public static void Ejecutar()
    {
        string frase;
        Console.Write("¿Frase?: ");
        frase = Convert.ToString(Console.ReadLine());
        while(frase.Contains("  "))
        {
           frase = frase.Replace("  ", " ");
        }
        Console.WriteLine(frase);
    }
}
