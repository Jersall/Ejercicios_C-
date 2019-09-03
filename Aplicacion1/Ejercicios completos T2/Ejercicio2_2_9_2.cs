/*Ejercicio 2.2.9.2: Que pida al usuario 2 numeros y escriba sus divisores comunes.
Usa llaves en todas las frases aunque incluyan solo 1 sentencia.*/
using System;
public class Ejercicio2_2_9_2
{
	public static void Main()
	{
		Console.WriteLine("Introduce el primer número: ");
		int n1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce el segundo número: ");
		int n2 = Convert.ToInt32(Console.ReadLine());
		for (int divisor = 1; ((divisor <= n1) || (divisor <= n2)) ; divisor++)
		{
			if ((n1 % divisor == 0) && (n2 % divisor == 0))
			{
				Console.WriteLine("{0} es un divisor común de ambos números.", divisor);
			}
		}
	}
}