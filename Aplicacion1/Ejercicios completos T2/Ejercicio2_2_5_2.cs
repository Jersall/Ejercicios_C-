/*Ejercicio 2.2.5.2: Crea un program que escriba 4 veces los numeros del 1 al 5 en 
una misma línea, usando "while"*/
using System;
public class Ejercicio2_2_5_2
{
	public static void Ejecutar()
	{
		int veces = 1, numero = 1;
		while(veces <= 4)
		{
			Console.Write("{0} ", numero);
			numero = numero + 1;
			if (numero == 6)
			{
				veces = veces + 1;
				numero = 1;
			}
		}
	}
}