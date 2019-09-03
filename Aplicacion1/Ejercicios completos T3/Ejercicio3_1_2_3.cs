/*Ejercicio 3.1.2.3: Pide al usuario 2 numeros enteros largos(long) y muestra suma, 
resta y producto.*/
using System;
public class Ejercicio3_1_2_3
{
	public static void Ejecutar()
	{
		long n1, n2;
		Console.Write("¿Numero 1?: ");
		n1 = Convert.ToInt64(Console.ReadLine());
		Console.Write("¿Numero 2?: ");
		n2 = Convert.ToInt64(Console.ReadLine());
		Console.WriteLine("{0} + {1} = {2}", n1, n2, n1+n2);
		Console.WriteLine("{0} - {1} = {2}", n1, n2, n1-n2);
		Console.WriteLine("{0} · {1} = {2}", n1, n2, n1*n2);
	}
}