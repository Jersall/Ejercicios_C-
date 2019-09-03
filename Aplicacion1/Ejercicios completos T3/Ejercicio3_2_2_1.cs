/*Ejercicio 3.2.2.1: Crea un programa que muestre el resultado de dividir 
13 entre 6 usando int, luego float, y por ultimo double*/
using System;
public class Ejercicio3_2_2_1
{
	public static void Ejecutar()
	{
		int n1 = 13, n2 = 6, d1 = n1 / n2;
		float n3 = 13, n4 = 6, d2 = n3 / n4;
		double n5 = 13, n6 = 6, d3 = n5 / n6;
		Console.WriteLine("(int)13 / 6 = {0}", d1);
		Console.WriteLine("(float)13 / 6 = {0}", d2);
		Console.WriteLine("(double)13 / 6 = {0}", d3);
	}
}