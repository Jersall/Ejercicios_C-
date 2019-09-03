/*Ejercicio 3.2.2.2: Calcula el area de un circulo dando su radio, 
que será un número entero(area = pi * r^2)*/
using System;
public class Ejercicio3_2_2_2
{
	public static void Main()
	{
		int rads;
		Console.WriteLine("¿Longitud del radio(r)?: ");
		rads = Convert.ToInt32(Console.ReadLine());
		float pi = 3.14f;
		Console.Write("{0} · {1} ^2 = ", pi, rads);
		rads = rads * rads;
		double area = rads * pi;
		Console.WriteLine(area);
	}
}
