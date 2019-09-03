/*Crea una nueva versión del programa que calcula el producto de dos numeros introducidos por el
 usuario así cono el resto de esa división, empleando "using System". 
 Deberas incluir un comentario con tu nombre y la fecha en la que has realizado el programa.*/
/*El ejercicio parte desde el ejercicio 1.9.2: Calcular división y resto introducidos por usuario*/
using System;
public class Ejercicio1_10_2
{
	public static void Main()
	{
		int n1, n2, coc, res;
		Console.WriteLine("Introduce el dividendo");
		n1 = Convert.ToInt32
		(
			Console.ReadLine()
		);
		Console.WriteLine("Introduce el divisor");
		n2 = Convert.ToInt32
		(
			/*Juan José Rafet Ferrer, 2/7/2019*/
			Console.ReadLine()
		);
		coc = n1 / n2;
		res = n1 % n2;
		Console.WriteLine("{0}/{1}={2}, residuo de {3}", n1, n2, coc, res);
	}
}