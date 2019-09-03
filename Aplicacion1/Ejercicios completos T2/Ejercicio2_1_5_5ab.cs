/*Ejercicio 2.1.5.5: Crea un programa que pida al usuario 2 numeros enteros y diga si ambos son pares*/
/*Ejercicio 2.1.5.6: Crea un programa que pida dos numeros enteros y diga si al menos 1 es par*/
/*Iniciativa propia: Que diga si ninguno de los numeros es par; 
en caso de haber solo 1 par, diga cual lo es y cual no*/
using System;
public class Ejercicio2_1_5_5ab
{
	public static void Main()
	{
		int n1, n2;
		Console.Write("Introduce un número entero: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número entero: ");
		n2 = Convert.ToInt32(Console.ReadLine());
		if ((n1 % 2 == 0) && (n2 % 2 == 0))
			Console.WriteLine("Ambos números son pares");
		else
			if (n1 % 2 == 0)
			{
				Console.WriteLine("El número {0} es par", n1);
				Console.WriteLine("El número {0} es impar", n2);
			}
			else
				if (n2 % 2 == 0)
				{
					Console.WriteLine("El número {0} es par", n2);
					Console.WriteLine("El número {0} es impar", n1);
				}
				else
					Console.WriteLine("Ambos números son impares");
	}
}