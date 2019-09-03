/*Ejercicio 2.2.12.1: Crea un programa que escriba los numeros del 100 al 200 separados 
por un espacio, sin avanzar de línea usando "for". En la siguiente línea, 
vuelve a escribirlos usando while.*/
using System;
public class Ejercicio2_2_12_1
{
	public static void Ejecutar()
	{
		int i;
		for (i = 100; i <= 200; i++)
		{
			if (i < 200)
			Console.Write("{0} ", i);
			else
			Console.WriteLine("{0} ", i);
		}
		i = 100;
		while (i <= 200)
		{
			if (i < 200)
			Console.Write("{0} ", i);
			else
			Console.WriteLine("{0} ", i);
			i++;
		}
	}
}