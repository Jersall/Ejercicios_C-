/*Ejercicio 2.2.8.2: Crea un programa que pida al usuario el ancho y el alto y escriba un 
rectángulo formado por esa cantidad de asteriscos(Como el ejercicio 2.2.6.2). 
Deberás usar las variables de "ancho" y "alto" para los datos que pidas al usuario, 
y las variables "filaactual" y "columnaactual" (no me da la gana, las llamaré como quiera.) 
declaradas en el for para el bloque repetitivo.*/
using System;
public class Ejercicio2_2_8_2
{
	public static void Ejecutar()
	{
		Console.Write("Introduce un número entero(alto): ");
		int dalto = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un número entero(ancho): ");
		int dancho = Convert.ToInt32(Console.ReadLine());
		for (int alto = 1; alto <= dalto; alto++)
			if ((dancho == 1) && (dalto == 1))
				Console.WriteLine("*");
			else
			{
				if ((dancho == 1) && (dalto != 1))
					Console.WriteLine("*");
				else
				{
					for (int ancho = 1; ancho <= dancho - 1; ancho++)
					{
						Console.Write("*");
						if (ancho == dancho - 1)
							Console.WriteLine("*");
					}
				}
			}
	}
}