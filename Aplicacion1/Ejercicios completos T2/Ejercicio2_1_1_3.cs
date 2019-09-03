/*Ejercicio 2.1.1.3: Crea un programa que pida al usuario dos numeros 
y diga si el primero es multiple del segundo. Pista: "a % b == 0"*/
using System;
public class Ejercicio2_1_1_3
{
	public static void Main()
	{
		int n1, n2;
		Console.Write("Introduce el primer numero, que dividiremos: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("¿Qué numero necesitas saber si es divisor de {0}?: ", n1);
		n2 = Convert.ToInt32(Console.ReadLine());
		if (n1 % n2 == 0)
			Console.WriteLine("{0} es un divisor de {1}", n2, n1);
			else Console.WriteLine("{0} no es un divisor de {1}", n2, n1);
	}
}