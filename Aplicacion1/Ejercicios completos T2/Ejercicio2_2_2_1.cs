/*Ejercicio 2.2.2.1: Crear un programa que pida numeros positivos al usuario y vaya calculando 
y mostrando la suma de todos ellos. Terminará cuando se teclee un número negativo, o 0.*/
/*using System;
public class Ejercicio2_2_2_1
{
	public static void Main()
	{
		int n1, n2, n3, suma;
		Console.Write("Introduce un número entero: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce el segundo número entero: ");
		n2 = Convert.ToInt32(Console.ReadLine());
		suma = n1 + n2;
		Console.Write("{0} + {1} = {2} ", n1, n2, suma);
		do
		{
			Console.WriteLine("¿Sumar más?");
			Console.Write("(0 o negativo para salir): ");
			n3 = Convert.ToInt32(Console.ReadLine());
			if (n3 > 0)
			{
			Console.Write("{0}", suma);
			suma = n3 + suma;
			Console.WriteLine(" + {0} = {1}", n3, suma);
			}
		}
		while (n3 > 0);
		Console.WriteLine("Pues si no sumas más, me cierro.");
	}
}*/
using System;
public class Ejercicio2_2_2_1
{
	public static void Main()
	{
		int n1, n2, suma;
		Console.Write("Introduce un número entero: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce el segundo número entero: ");
		do
		{
			n2 = Convert.ToInt32(Console.ReadLine());
			if (n2 > 0)
			{
				suma = n1 + n2;
				Console.WriteLine("{0} + {1} = {2}", n1, n2, suma);
				n1 = suma;
				Console.WriteLine("¿Sumar más?");
				Console.Write("0 para salir: ");
			}
		}
		while (n2 > 0);
		Console.WriteLine("Pues si no sumas más, me cierro");
	}
}