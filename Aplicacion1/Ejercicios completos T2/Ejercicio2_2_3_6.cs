/*Ejercicio 2.2.3.6: Crea un programa que muestre los numeros del 
15 al 5 en orden descendiente.*/
using System;
public class Ejercicio2_2_3_6
{
	public static void Main()
	{
		int descendiente;
		for (descendiente = 15; descendiente >= 5; descendiente--)
			Console.WriteLine(descendiente);
	}
}