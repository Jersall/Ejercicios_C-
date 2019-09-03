/*Ejercicio 2.2.10.1: Crea un programa que pida al usuario dos numeros y 
escriba su máximo común divisor*/
using System;
public class Ejercicio2_2_10_1
{
	public static void Main()
	{
		int n1, n2;
		Console.Write("Introduce un número entero(1): ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un número entero(2): ");
		n2 = Convert.ToInt32(Console.ReadLine());
		for (int i = n1 <= n2 ? n1 : n2; i >= 1; i--)
		{
			if ((n1 % i == 0) && (n2 % i == 0))
			{
				Console.WriteLine("{0} es el máximo común divisor de ambos numeros.", i);
				break;
			}
		}
	}
}
