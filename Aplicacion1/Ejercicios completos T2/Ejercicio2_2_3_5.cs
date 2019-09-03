/*Ejercicio 2.2.3.5: Crea un programa que muestre los primeros ocho numeros pares(del 2 al 16)*/
using System;
public class Ejercicio2_2_3_5
{
	public static void Ejecutar()
	{
		int par;
		for(par = 1; par <= 8; par++)
			Console.WriteLine(par * 2);
	}
}