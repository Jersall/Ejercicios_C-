/*Ejercicio 2.1.1.2: Crea un programa que pida al usuario 
dos numeros enteros y diga cual de los dos es mayor.*/
using System;
public class Ejercicio2_1_1_2
{
	public static void Main()
	{
		int n1, n2;
		Console.Write("Introduce un número: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un segundo número: ");
		n2 = Convert.ToInt32(Console.ReadLine());
		if (n1 > n2)
			Console.WriteLine("{0} es mayor que {1}", n1, n2);
		if (n1 < n2)
			Console.WriteLine("{0} es menor que {1}", n1, n2);
		if (n1 == n2)
			Console.WriteLine("Los números son iguales");
	}
}