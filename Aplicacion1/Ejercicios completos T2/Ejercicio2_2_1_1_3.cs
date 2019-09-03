/*Ejercicio 2.2.1.1.3: Crea un programa que pida de forma repetitiva pares de números. 
Tras introducir los números el programa dirá si el primero es múltiplo del segundo.*/
using System;
public class Ejercicio2_2_1_1_3
{
	public static void Main()
	{
		int n1, n2;
		Console.Write("Introduce un número entero: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		n2 = 0;		
		while(n1 != 0)
		{
			Console.Write("Introduce otro número entero: ");
			n2 = Convert.ToInt32(Console.ReadLine());
			if (n2 % n1 == 0)
				Console.WriteLine("{0} es múltiple de {1}", n1, n2);
			else Console.WriteLine("{0} no es múltiple de {1}", n1, n2);
			Console.Write("Introduce un número entero: ");
			n1 = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("¡Hasta otra!");
	}
}