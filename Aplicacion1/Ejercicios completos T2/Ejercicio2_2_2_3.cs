/*Ejercicio 2.2.2.3: Crea un programa que muestre los numeros pares del 26 al 10 
descendiente usando do while*/
/*Complicación random: ¿Y los pares de 27 a 10?*/
using System;
public class Ejercicio2_2_2_3
{
	public static void Main()
	{
		int cuenta = 27;
		cuenta = cuenta - 1;
		do
		{
			Console.WriteLine(cuenta);
			cuenta = cuenta - 2;
		}
		while (cuenta >= 10);
	}
}