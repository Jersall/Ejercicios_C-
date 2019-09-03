/*Ejercicio 2.2.5.1: Crea un programa que escriba 4 veces los numeros del 1 al 5 en una misma 
linea usando for: "12345123451234512345"*/
using System;
public class Ejercicio2_2_5_1
{
	public static void Ejecutar()
	{
		int veces, numero;
		for (veces = 1; veces <= 4; veces++)
			for(numero = 1; numero <= 5; numero++)
				Console.Write("{0}", numero);
	}
}