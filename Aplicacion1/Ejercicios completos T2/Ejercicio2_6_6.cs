/*Ejercicio 2.6.6: Crea un programa que dibuje un rectangulo hueco cuyo borde sea una 
fila de asteriscos, con el interior en espacios en blanco.
El numero debe indicarlo el usuario.*/
using System;
public class Ejercicio2_6_6
{
	public static void Main()
	{
		int ancho, alto, datoancho, datoalto;
		Console.Write("Introduce un número entero(Alto): ");
		datoalto = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un número entero(Ancho): ");
		datoancho = Convert.ToInt32(Console.ReadLine());
		for (alto = 1; alto <= datoalto; alto++)
			for (ancho = 1; ancho <= datoancho; ancho++)
			{
				if (ancho != datoancho)
				{
					if ((alto == 1) || (alto == datoalto) || (ancho == 1))
					Console.Write("*");
					else
					Console.Write(" ");
				}
				if (ancho == datoancho - 1)
					Console.WriteLine("*");
			}
	}
}