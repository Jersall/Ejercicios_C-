/*Ejercicio 2.2.12.2: Crea un programa que escriba los numeros 
pares del 20 al 10, descendiendo, a excepción del 14. Primero con for, luego con while.*/
using System;
public class Ejercicio2_2_12_2
{
	public static void Main()
	{
		int i;
		for (i = 20; i >= 10; i--)
		{
			if (i == 14)
				continue;
			else
			{
				Console.Write("{0} ", i);
			}
		}
		Console.WriteLine();
		i = 20;
		while (i >= 10)
		{
			if (i == 14)
			{
				i--;
				continue;
			}
			Console.Write("{0} ", i);
			i--;


			
		}

	}
}