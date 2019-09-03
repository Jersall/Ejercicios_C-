/*Ejercicio 2.2.2.2: Crea un programa que escriba en pantalla los numeros del 
1 al 10 empleando do while*/

using System;
public class Ejercicio2_2_2_2
{
	public static void Ejecutar()
	{
		int conteo = 1;
		do
		{
			Console.WriteLine(conteo);
			conteo = conteo + 1;
		}
		while (conteo <= 10);
	}
}