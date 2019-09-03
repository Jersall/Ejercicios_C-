/*Ejercicio 1.10.1: Usando using System, crea una nueva version del ejercicio 1.9.1. 
El programa debera incluir un comentario al principio que recuerde su cometido(Como este enunciado)*/
/*Debemos calcular el producto de dos numeros introducidos por el usuario*/
using System;
public class Ejercicio1_10_1
{
	public static void Ejecutar()
	{
		int n1, n2, producto;
		Console.WriteLine("Introduce el primer digito");
		n1 = Convert.ToInt32
		(
			Console.ReadLine()
		);
		Console.WriteLine("Introduce el segundo digito");
		n2 = Convert.ToInt32
		(
			Console.ReadLine()
		);
		producto = n1 * n2;
		Console.WriteLine("{0}*{1}={2}", n1, n2, producto);
	}
}