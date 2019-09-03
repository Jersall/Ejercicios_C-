/*Crea un programa que pida al usuario una contraseña que solo cierre si se introduce 
el número 1111. El programa pedirá la contraseña tantas veces como sea necesario.*/
using System;
public class Ejercicio2_2_1_1_1
{
	public static void Ejecutar()
	{
		int contra;
		Console.Write("Introduce la contraseña: ");
		contra = Convert.ToInt32(Console.ReadLine());
		while (contra != 1111)
		{
			Console.WriteLine("Contraseña incorrecta.");
			Console.Write("Por favor, introduce la contraseña: ");
			contra = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Contraseña correcta, Bienvenido.");
	}
}