/*Ejercicio 2.2.3.2: Crea un programa que escriba en pantalla los numeros del 1 al 50 que sean multiplos de 3.*/
using System;
public class Ejercicio2_2_3_2
{
	public static void Ejecutar()
	{
		int cont;
		for (cont = 3; cont <= 50; cont = cont + 3)
			Console.Write("{0} ", cont);
	}
}