/*Ejercicio 2.2.10.2: Un programa que pida al usuario 2 numeros y 
escriba su minimo comun multiple.*/
using System;
public class Ejercicio2_2_10_2
{
	public static void Ejecutar()
	{
		int n1, n2;
		Console.Write("Introduce un número entero(1): ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un número entero(2): ");
		n2 = Convert.ToInt32(Console.ReadLine());
		for (int i = n1 >= n2 ? n1 : n2; i <= i*10; i++)
		{
			if ((i % n1 == 0) && (i % n2 == 0))
			{
				Console.WriteLine("{0} es el minimo común múltiple de ambos numeros.", i);
				break;
			}
		}
	}
}