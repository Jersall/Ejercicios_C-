/*Ejercicio 2.1.5.8: Crea un programa que pida al usuario dos numeros enteros y diga:
- Uno de los numeros es positivo
- Los dos numeros son positivos
- Ninguno de los numeros es positivo*/
/*Iniciativa: Además el programa dirá que número es positivo y que numero es negativo*/
using System;
public class Ejercicio2_1_5_8
{
	public static void Main()
	{
		int n1, n2;
		Console.Write("Introduce un número entero: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número entero: ");
		n2 = Convert.ToInt32(Console.ReadLine());
		if ((n1 > 0) && (n2 > 0))
			Console.WriteLine("Ambos números son positivos");
			else
				if (n1 > 0)
				{
					Console.WriteLine("{0} es un número positivo", n1);
					Console.WriteLine("{0} es un número negativo", n2);
				}
				else
					if (n2 > 0)
					{
					Console.WriteLine("{0} es un número negativo", n1);
					Console.WriteLine("{0} es un número positivo", n2);
					}
					else
						Console.WriteLine("Ambos números son negativos");
	}
}