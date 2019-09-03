/*Ejercicio 2.6.3: Crea un programa que dibuje un rectángulo formado por asteriscos, 
con el ancho y el alto que indique el usuario, usando dos for anidados.*/
using System;
public class Ejercicio2_6_4
{
	public static void main()
	{
		int ancho, alto, dancho, dalto;
		Console.Write("Introduce un número entero(Alto): ");
		dalto = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un número entero(Ancho): ");
		dancho = Convert.ToInt32(Console.ReadLine());
		for (alto = 1; alto <= dalto; alto++)
			for(ancho = 1; ancho = dancho - 1; ancho++)
			{
				Console.Write("*");
				if (ancho == dancho - 1)
					Console.WriteLine("*")
			}
	}
}