/*Ejercicio 1.11.1: El usuario tecleará dos numeros, y el programa mostrara el resultado 
de la operación "(a+b)*(a-b)" y el resultado de "a^2-b^2" en la misma línea.*/
using System;
public class Ejercicio1_11_1
{
	public static void Main()
	{
		int nA, nB, rA, rB; 
		Console.Write("Introduce el digito 1: ");
		nA = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce el digito 2: ");
		nB = Convert.ToInt32(Console.ReadLine());
		rA = (nA + nB) * (nA - nB);
		rB = (nA * nA) - (nB * nB);
		Console.WriteLine("({0}+{1})*({2}-{3})= {4}, {5}^2-{6}^2= {7}", 
			nA, nB, nA, nB, rA, nA, nB, rB);
	}
}