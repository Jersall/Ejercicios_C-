/*Ejercicio 3.2.3.1: Calcula el volumen de una esfera, dado su radio, que será un numero 
de doble precisión. (vol = pi * r^3 * 4/3)*/
using System;
public class Ejercicio3_2_3_1
{
	public static void Main()
	{
		double radio, vol;
		float pi = 3.14f;
		Console.Write("¿Radio?(Decimal): ");
		radio = Convert.ToDouble(Console.ReadLine());
		radio = radio * radio * radio;
		vol = pi * radio * (4 / 3);
		Console.WriteLine("{0} · {1} · 4 / 3 = {2}", pi, radio, vol);
	}
}
