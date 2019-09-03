/*Ejercicio 2.6.9: Crea un programa que forme un cuadrado de numeros sucesivos por línea 
de la altura y anchura indicada por el usuario:
1111
2222
3333
4444*/
using System;
public class Ejercicio2_6_9
{
	public static void Main()
	{
		int alto, ancho, datoalto, datoancho, numero = 1;
		Console.Write("(Max 9)¿Alto?: ");
		datoalto = Convert.ToInt32(Console.ReadLine());
		Console.Write("(Max 9)¿Ancho?: ");
		datoancho = Convert.ToInt32(Console.ReadLine());
		if ((datoalto <= 9) && (datoancho <= 9))
		{
			for (alto = 1; alto <= datoalto; alto++)
			{
				for (ancho = 1; ancho <= datoancho - 1; ancho++)
				{ 
					Console.Write(numero);
					if (ancho == datoancho - 1)
						Console.WriteLine(numero);
				}
				numero++;
			}
		}
		else
			Console.WriteLine("Error: Un número de 2 cifras rompe la forma del cuadrado");
	}
}