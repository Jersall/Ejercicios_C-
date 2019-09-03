/*Ejercicio 2.2.9.1: Crea un programa que pida un numero al usuario y escriba los multiplos 
de 9 que haya por ese número. Usa llaves para todas las sentencias.*/
using System;
public class Ejercicio2_2_9_1
{
	public static void Ejecutar()
	{
		Console.Write("Introduce un número, sacaré múltiples de 9: ");
		int dnueve = Convert.ToInt32(Console.ReadLine());
		for (int multiple = 9; multiple <= 90; multiple = multiple + 9)
		{
			Console.WriteLine("{0} x {1} = {2}", dnueve, multiple, dnueve*multiple);
		}
	}
}