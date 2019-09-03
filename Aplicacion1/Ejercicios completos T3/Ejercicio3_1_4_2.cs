/*Ejercicio 3.1.4.2: Cuál sería el restultado de las siguientes operaciones?:
a = 5
b = a+2
b -= 3
c = -3
c *= 2
++c
a *= b
Crea un programa que te muestre una comparativa con tu resultado.*/
/*
A mano: 
a = 5;
b = 7
b = 7 - 3 = 4;
c = -3
c = -3 * 2 = -6 + 1 = -5;
a = 5*4 = 20
a = 20, b = 4, c = -4
*/
using System;
public class Ejercicio3_1_4_2
{
	public static void Main()
	{
		int a, b, c;
		a = 5;
		b = a+2;
		b -= 3;
		c = -3;
		c *= 2;
		++c;
		a *= b;
		Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
	}
}