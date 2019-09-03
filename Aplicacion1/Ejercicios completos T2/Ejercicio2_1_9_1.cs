/*Ejercicio 2.1.9.1: Crea un programa que pida un número del 1 al 5 al usuario. 
El programa escribirá en letra el nombre de ese número (1 // "uno")*/
using System;
public class Ejercicio2_1_9_1
{
	public static void Ejecutar()
	{
		char n1_5;
		Console.Write("Introduce un número del 1 al 5, los traduciré para los de letras: ");
		n1_5 = Convert.ToChar(Console.ReadLine());
		switch (n1_5)
		{
			case '1': Console.WriteLine("Uno.");
				break;
			case '2': Console.WriteLine("Dos.");
				break;
			case '3': Console.WriteLine("Tres.");
				break;
			case '4': Console.WriteLine("Cuatro");
				break;
			case '5': Console.WriteLine("Cinco.");
				break;
			default: Console.WriteLine("Eh, eh, eh, un número del 1 al 5, tampoco nos pasemos.");
				break;
		}
	}
}