/*Ejercicio 2.2.1.1.2: Crea un calculador de cuadrados: pedirá al usuario un número 
y mostrará su cuadrado. Usa While para que siga pidiendo números.*/
using System;
public class Ejercicio2_2_1_1_2
{
	public static void Ejecutar()
	{
		int n, cuadrado;
		Console.WriteLine("Introduce un número entero.(0 para salir)");
		Console.Write("Se calculará su potencia de 2(Cuadrado): ");
		n = Convert.ToInt32(Console.ReadLine());
		while (n != 0)
		{
			cuadrado = n * n;
			Console.WriteLine("                                         {0}^2 = {1}", n, cuadrado);
			Console.WriteLine("Introduce un número entero.(0 para salir)");
			Console.Write("Se calculará su potencia de 2(Cuadrado): ");
			n = Convert.ToInt32(Console.ReadLine());
		}
	}
}