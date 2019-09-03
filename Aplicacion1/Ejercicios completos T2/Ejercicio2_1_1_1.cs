/*Ejercicio 2.1.1.1: Crea un programa que pida al usuario un numero entero y diga si es par o impar*/
using System;
public class Ejercicio2_1_1_1
{
	public static void Ejecutar()
	{
		int nume;
		Console.Write("Introduce un dígito ");
		nume = Convert.ToInt32(Console.ReadLine());
		if (nume == 0) Console.WriteLine("Eso es un cero");
		if (nume % 2 == 0) Console.WriteLine("El número es par");
		else Console.WriteLine("El número es impar");
	}
}