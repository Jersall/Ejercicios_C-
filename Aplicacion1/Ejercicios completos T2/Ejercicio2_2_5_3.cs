/*Ejercicio 2.2.5.3: Crea un programa que para los numeros entre 10 y 20, ambos incluidos, 
diga si son divisibles entre 5, 6, o 7.*/
using System;
public class Ejercicio2_2_5_3
{
	public static void Main()
	{
		int numero;
		for (numero = 10; numero <= 20; numero++)
			{
				if(numero % 5 == 0)
					Console.WriteLine("{0} es multiple de 5.", numero);
				if(numero % 6 == 0)
					Console.WriteLine("{0} es multiple de 6.", numero);
				if(numero % 7 == 0)
					Console.WriteLine("{0} es multiple de 7.", numero);
			}
	}
}