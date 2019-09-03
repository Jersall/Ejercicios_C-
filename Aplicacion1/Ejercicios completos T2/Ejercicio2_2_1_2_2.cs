/*Ejercicio 2.2.1.2.2Crea un programa que escriba en pantalla los numeros pares del 
26 al 10(Descendiente) usando while.*/
using System;
public class Ejercicio2_2_1_2_2
{
	public static void Main()
	{
		int n1 = 26;
		while(n1 != 8)
		{
			Console.WriteLine(n1);
			n1 = n1 - 2;
		}
	}
}