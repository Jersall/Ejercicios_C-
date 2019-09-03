/*Ejercicio 2.2.6.2: Crea un programa que pida al usuario el ancho y el alto y 
escriba un rectángulo(O cuadrado) formado por asteriscos.*/
using System;
public class Ejercicio2_2_6_2
{
	public static void Main()
	{
		int ancho, alto, dancho, dalto;
		Console.WriteLine("Introduce un número entero(Ancho): " );
		dancho = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce un número entero(Alto): " );
		dalto = Convert.ToInt32(Console.ReadLine());
		for(alto = 1; alto <= dalto; alto++)
			for(ancho = 1; ancho <= dancho - 1; ancho++)
			{
				Console.Write("*");
				if(ancho == dancho - 1)
					Console.WriteLine("*");
			}
	}
}