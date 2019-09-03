/*Ejercicio 3.2.5.1: El usuario de nuestro programa podra teclear dos numeros de 
hasta 12 cifras significativas. El programa debera mostrar el resultado de dividir el 
primer numero entre el segundo, utilizando 3 cifras decimales*/
using System;
public class Ejercicio3_2_5_1
{
	public static void Main()
	{
		double n1 = 1, n2 = 1, division = 0;
		while ((n1 > 0) && (n2 > 0))
		{
			Console.Write("¿N1?: ");
			n1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("¿N2?: ");
			n2 = Convert.ToDouble(Console.ReadLine());
			if ((n1 < 1000000000000) && (n2 < 1000000000000))
			{
				division = n1 / n2;
				if ((n1 > 0) && (n2 > 0))
				{
					Console.WriteLine(division.ToString("N3"));
				}
			}
			else
			{
				Console.WriteLine("Error: No puede ser más largo de 12 dígitos.");
			}
		}
	}
}