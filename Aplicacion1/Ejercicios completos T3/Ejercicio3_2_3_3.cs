/*Ejercicio 3.2.3.3: Halla las soluciones de una ecuación de segundo grado(ax^2 + bx + c)
"Pista": La raiz cuadrada de un numero x se calcula com Math.Sqrt(x)*/
/*formula:
x = -b +-(Raiz b^2 - 4·a·c)/(2·a)*/
using System;
public class Ejercicio3_2_3_3
{
	public static void Main()
	{
		Double a, b, c, ecuacionp, ecuacionn, raiz, raizp;
		Console.Write("¿x^2(a)?: ");
		a = Convert.ToDouble(Console.ReadLine());
		Console.Write("¿x(b)?: ");
		b = Convert.ToDouble(Console.ReadLine());
		Console.Write("¿simple(c)?: ");
		c = Convert.ToDouble(Console.ReadLine());
		raizp = (b * b) - (4 * a * c);
		raiz = Math.Sqrt(raizp);
		ecuacionp = ((b * -1) + raiz) / (2 * a);
		ecuacionn = ((b * -1) - raiz) / (2 * a);
		Console.WriteLine("x = {0}", ecuacionp);
		Console.WriteLine("x = {0}", ecuacionn);
	}
}