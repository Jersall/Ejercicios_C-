/*Ejercicio 3.1.1.1: Calcula el producto de 1M · 1M, usando una variable "producto" 
de tipo "long". Prueba a calcularlo con un int.*/

using System;
public class Ejercicio3_1_1_1
{
	public static void Main()
	{
		long producto = 1000000;
		Console.WriteLine("{0} · {0} = {1}", producto, producto * producto);
	}
}
/*
using System;
public class Ejercicio3_1_1_1
{
	public static void Main()
	{
		int producto = 1000000;
		Console.WriteLine("{0} · {0} = {1}", producto, producto * producto);
	}
}
*/