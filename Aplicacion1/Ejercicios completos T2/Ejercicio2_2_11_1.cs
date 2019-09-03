/*Ejercicio 2.2.11.1: Crea un programa que escriba los numeros del 20 al 10, 
descendiendo excepto el 13. Usa Continue.*/
using System;
public class Ejercicio2_2_11_1
{
	public static void Main()
	{
		int i;
		for (i = 20; i >= 10; i--)
		{
			if (i == 13)
				continue;
			Console.Write("{0} ", i);
		}
	}
}