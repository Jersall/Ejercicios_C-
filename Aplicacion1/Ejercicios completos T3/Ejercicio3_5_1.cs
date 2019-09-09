/*Ejercicio 3.5.1: Crea un programa que use el operador condicional para dar a 
 * una variable llamada iguales (bool) el valor true si los dos numeros que ha 
 * tecleado el usuario son iguales, o false si son distintos*/

using System;

public class Ejercicio3_5_1
{
	public static void Ejecutar()
	{
        int n1, n2;
        bool iguales;
        Console.Write("¿Numero 1?");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Número 2?");
        n2 = Convert.ToInt32(Console.ReadLine());
        iguales = n1 == n2;
        if (iguales)
        {
            Console.WriteLine("Los numeros son iguales");
        }
        else
        {
            Console.WriteLine("Los números no son iguales");
        }
	}
}
