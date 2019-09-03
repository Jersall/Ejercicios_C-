/*Crea un programa que muestre los numeros del 100 al 200(ambos incluidos que sean divisibles entre 7 y a la vez entre 3*/
using System;
public class Ejercicio2_2_3_1_3
{
	public static void Ejecutar()
	{
		int conteo;
		for (conteo = 100; conteo <= 200; conteo++)
			if((conteo % 3 == 0) && (conteo % 7 == 0))
				Console.WriteLine("{0}", conteo);
	}
}