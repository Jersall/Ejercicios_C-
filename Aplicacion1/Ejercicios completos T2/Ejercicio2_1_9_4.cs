/*Ejercicio 2.1.9.4: Ejercicio 2.1.9.1 con if en lugar de switch
(de 1 a 5, que diga "uno" a "cinco" a cambio.).*/
using System;
public class Ejercicio2_1_9_4
{
	public static void Ejecutar()
	{
		int n1;
		Console.Write("Di un número del 1 al 5, lo traduciré para los de letras.");
		n1 = Convert.ToInt32(Console.ReadLine());
		if ((n1 == 1) || (n1 == 2) || (n1 == 3) || (n1 == 4) || (n1 == 5))
			{
				if (n1 == 1)
				Console.WriteLine("Uno.");
				if (n1 == 2)
				Console.WriteLine("Dos.");
				if (n1 == 3)
				Console.WriteLine("Tres.");
				if (n1 == 4)
				Console.WriteLine("Cuatro.");
				if (n1 == 5)
				Console.WriteLine("Cinco.");
			}
		else Console.WriteLine("He dicho del 1 al 5... {0} no es un número del 1 al 5...", n1);
	}
}