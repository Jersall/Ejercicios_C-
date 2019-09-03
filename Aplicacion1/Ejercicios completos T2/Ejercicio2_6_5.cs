/*Ejercicio 2.6.5: Crea un programa que dibuje un triángulo decreciente, 
con la altura que indique el usuario.*/
using System;
public class Ejercicio2_6_5
{
	public static void Ejecutar()
	{
		int dalto, alto = 0;
		Console.Write("Introduce un numero(Alto): ");
		dalto = Convert.ToInt32(Console.ReadLine());
		for (int ancho = dalto; ancho >= 0; ancho--)
		{
			dalto = dalto - 1;
			for (alto = dalto; alto >= 1; alto--)
			{
				Console.Write("*");
				if (alto == 1)
					Console.WriteLine("*");
			}
			if (ancho == 0)
				Console.WriteLine("*");
		}
	}
}