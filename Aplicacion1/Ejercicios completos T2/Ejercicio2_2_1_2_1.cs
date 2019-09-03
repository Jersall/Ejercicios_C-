/*Ejercicio 2.2.1.2.1: Crea un programa que escriba los numeros del 1 al 10 usando while*/

using System;
public class Ejercicio2_2_1_2_1
{
	public static void Main()
	{
		int n1 = 1;
		while(n1 <= 10)
		{
			Console.WriteLine(n1);
			n1 = n1 + 1;
		}
	}
}