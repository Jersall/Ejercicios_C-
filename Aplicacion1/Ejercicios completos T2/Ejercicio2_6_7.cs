/*Ejercicio 2.6.7: Crea un programa que dibuje un triangulo creciente alineado a la derecha. 
Con la altura que indique el usuario.*/
using System;
public class Ejercicio2_6_7
{
	public static void Main()
	{
		int datoalto, alto, ancho;
		Console.Write("Introduce un número entero(Alto)");
		datoalto = Convert.ToInt32(Console.ReadLine());
		for (alto = 1; alto <= datoalto; alto++)
			for (ancho = datoalto; ancho >= 0; ancho--)
			{
				if ((ancho >= alto) && (ancho != datoalto))
					Console.Write(" ");
				else
				{
					if ((ancho < alto) && (ancho != 0))
					Console.Write("*"); 
					if (ancho == 0)
					Console.WriteLine("*");
				}
			}
	}		
}
