/*Ejercicio 3.5.2: Crea una versión alternativa del ejercicio 3.5.1 que use 
if en vez del operador condicional*/
using System;

public class Ejercicio3_5_2
{
    public static void Ejecutar()
    {
        int n1, n2;
        Console.Write("¿Numero 1?: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Número 2?: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        if (n1 == n2)
        {
            Console.WriteLine("Los números son iguales");
        }
        else
        {
            Console.WriteLine("Los numeros no son iguales");
        }
    }
}
