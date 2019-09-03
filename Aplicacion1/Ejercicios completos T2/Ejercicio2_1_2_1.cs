/*Ejercicio 2.1.2.1: Crea un programa que pida al usuario un numero entero. 
Si es muliple de 10, informará al usuario y pedirá un segundo número, para decir 
si este número también es multiplo de 10.*/
using System;
public class Ejercicio2_1_2_1
{
	public static void Ejecutar()
	{
		int n1, n2;
		Console.Write("Introduce un número: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		if (n1 % 10 == 0)
		{
			Console.WriteLine("¡Este número es múltiple de 10!");
			Console.Write("¡Dime otro! ¡Dime otro!: ");
			n2 = Convert.ToInt32(Console.ReadLine());
			if (n2 % 10 == 0) Console.WriteLine("¡Este también!");
			else Console.WriteLine("No... este no es múltiple de 10...");
		}
		else Console.WriteLine("Éste número no es múltiple de 10");
	}
}