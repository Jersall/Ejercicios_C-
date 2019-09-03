/*Ejercicio 2.2.6.1: Crea un programa que escriba 4 lineas de texto, cada una de las cuales estará formada por numeros del 1 al 5*/
using System;
public class Ejercicio2_2_6_1
{
	public static void Main()
	{
		int numero, veces;
		for (veces = 1; veces <=4; veces++)
		{
			for (numero = 1; numero <= 5; numero++)
				Console.Write("{0} ", numero);
			Console.WriteLine();
		}
	}
}