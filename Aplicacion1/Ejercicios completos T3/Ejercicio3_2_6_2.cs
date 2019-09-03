/*Ejercicio 3.2.6.2: Crea un programa que pida al usuario la cantidad de 
rojo, azul y verde que tiene un color y que muestre ese color RGB en notacion hexadecimal*/
using System;
public class Ejercicio3_2_6_2
{
	public static void Ejecutar()
	{
		int rojo, verde, azul;
		Console.Write("¿Rojo?(hasta 255): ");
		rojo = Convert.ToInt32(Console.ReadLine());
		Console.Write("¿Verde?(hasta 255): ");
		verde = Convert.ToInt32(Console.ReadLine());
		Console.Write("¿Azul?(hasta 255): ");
		azul = Convert.ToInt32(Console.ReadLine());
		Console.Write(Convert.ToString(rojo, 16));
		Console.Write(Convert.ToString(verde, 16));
		Console.WriteLine(Convert.ToString(azul, 16));
	}
}