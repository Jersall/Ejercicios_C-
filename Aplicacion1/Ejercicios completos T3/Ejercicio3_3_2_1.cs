/*Ejercicio 3.3.2.1: Crea un programa que pida la usuario que teclee cuatro letras y 
las muestre en pantalla juntas, pero en orden inverso y entre comillas dobles.
(aloh = "hola")*/
using System;
public class Ejercicio3_3_2_1
{
	public static void Ejecutar()
	{
		Console.Write("¿Letra 1?: ");
		char l1 = Convert.ToChar(Console.ReadLine());
		Console.Write("¿Letra 2?: ");
		char l2 = Convert.ToChar(Console.ReadLine());
		Console.Write("¿Letra 3?: ");
		char l3 = Convert.ToChar(Console.ReadLine());
		Console.Write("¿Letra 4?: ");
		char l4 = Convert.ToChar(Console.ReadLine());
		Console.WriteLine("\"{0}{1}{2}{3}\"", l4, l3, l2, l1);
	}
}