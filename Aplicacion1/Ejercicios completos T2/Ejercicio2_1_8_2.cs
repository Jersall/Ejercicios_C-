/*Ejercicio 2.1.8.2: Usa el operador condicional para calcular el menor de dos números*/
using System;
public class Ejercicio2_1_8_2
{
	public static void Main()
	{
		int n1, n2, menor;
		Console.Write("Introduce un número: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		n2 = Convert.ToInt32(Console.ReadLine());
		menor = n1 < n2 ? n1 : n2;
		Console.WriteLine("El menor de los dos es {0}", menor);
	}
}