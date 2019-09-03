/*Ejercicio 3.2.6.3: Crea un programa para mostrar los números del 0 al 255 en hexadecimal 
en 16 filas de 16 columnas cada una.*/
using System;
public class Ejercicio3_2_6_3
{
	public static void Ejecutar()
	{
		int n = 0;
		while (n <= 255)
		{
			for(int alto = 0; alto <= 15; alto++)
			{
				for(int ancho = 0; ancho <= 14; ancho++)
				{
					Console.Write(Convert.ToString(n, 16));
					Console.Write(" ");
					n++;
					if (ancho == 14)
					{
						Console.WriteLine(Convert.ToString(n, 16));
						n++;
					}
				}
			}
		}
	}
}