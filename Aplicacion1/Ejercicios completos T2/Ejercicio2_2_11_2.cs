/*Ejercicio 2.2.11.2: Crea un programa que escriba los numeros pares del 2 al 106, 
excepto los que sean multiples de 10 usando continue.*/
using System;
public class Ejercicio2_2_11_2
{
	public static void Ejecutar()
	{
		int i;
		for (i = 1; i <= 106; i++)
		{
			if ((i % 2 == 0) && (i != 1))
			{
				if (i % 10 == 0)
					continue;
				if (i < 106)
				Console.Write("{0} ", i);
				else
				Console.WriteLine("{0} ", i);
			}
		}
	}
}