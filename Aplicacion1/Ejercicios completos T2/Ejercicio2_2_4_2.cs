/*Ejercicio 2.2.4.2: Crea un programa que contenga un bucle sin fin que muestre los 
numeros enteros positivos a partir del 1*/
using System;
public class Ejercicio2_2_4_2
{
	public static void Ejecutar()
	{
		int positivo;
		for (positivo = 1; positivo != 0; positivo++)
			Console.Write("{0} ", positivo);
	}
}