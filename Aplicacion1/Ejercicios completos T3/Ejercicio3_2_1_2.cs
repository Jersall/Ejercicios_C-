/*Ejercicio 3.2.1.2: ¿Cual sería el resultado de las siguientes operaciones, 
usando numeros reales?*/
/*
a = 5;
a /= 2;
a += 1;
a *= 3;
--a;
*/
/*Solución a mano:

a = 5;
5 / 2 = 2,5;
2,5 + 1 = 3,5;
3,5 · 3 = 10,5;
10,5 - 1 = 9,5;

Aplicación para corregir solución:*/
using System;
public class Ejercicio3_2_1_2
{
	public static void Main()
	{
		float a = 5;
		Console.WriteLine("a = {0}", a);
		a /= 2;
		Console.WriteLine("a = {0}", a);
		a += 1;
		Console.WriteLine("a = {0}", a);
		a *= 3;
		Console.WriteLine("a = {0}", a);
		--a;
		Console.WriteLine("a = {0}", a);
	}
}
/*Correcto;
error 1: he puesto inicialmente un int en lugar de un float, 
y la operación ha descuadrado completamente del cálculo*/