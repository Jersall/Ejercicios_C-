/*Ejercicio 2.2.7.1: Crea un programa que muestre las letras de la Z 
mayuscula a la A mayuscula en descendiente*/
using System;
public class Ejercicio2_2_7_1
{
	public static void Ejecutar()
	{
		char letra;
		for (letra = 'Z'; letra >= 'A'; letra--)
		{	
			Console.Write("{0} ", letra);
			if (letra == 'O')
				Console.Write("Ñ ");
		}
	}
}