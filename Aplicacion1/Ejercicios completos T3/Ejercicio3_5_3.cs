/*Ejercicio 3.5.3: Crea un programa que use el operador condicional para 
dar a una variable llamada "pares"(bool) True si los dos numeros son pares.
false si alguno es impar.*/
using System;
public class Ejercicio3_5_3
{
    public static void Ejecutar()
    {
        int n1, n2;
        Console.Write("¿Numero 1?");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Número 2?");
        n2 = Convert.ToInt32(Console.ReadLine());
        bool pares = ((n1 % 2 == 0) && (n2 % 2 == 0));
        if (pares)
        {
            Console.WriteLine("Pares");
        }
        else
        {
            Console.WriteLine("uno(o dos) impar(es).");
        }
    }
}