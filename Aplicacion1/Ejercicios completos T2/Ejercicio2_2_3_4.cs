/*Ejercicio 2.2.3.4: Crea un programa que muestre la tabla de multiplicar del 9*/
using System;
public class Ejercicio2_2_3_4
{
	public static void Ejecutar()
	{
		int nueve, multiplicador = -1;
		for (nueve = 0; nueve <= 90; nueve++)
			if (nueve % 9 == 0)
			{
				multiplicador = multiplicador + 1;
				Console.WriteLine("9 x {0} = {1}", multiplicador, nueve);
			}
	}
}