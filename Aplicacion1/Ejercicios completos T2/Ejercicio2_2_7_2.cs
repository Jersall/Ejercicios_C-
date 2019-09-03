/*Ejercicio 2.2.7.2: Crea un programa que muestre 5 veces las letras de la L a la N 
en la misma línea*/
using System;
public class Ejercicio2_2_7_2
{
	public static void Main()
	{
		int contador;
		char mayuscula;
		for (contador = 1; contador <= 5; contador++)
			for (mayuscula = 'L'; mayuscula <= 'N'; mayuscula++)
				Console.Write("{0}", mayuscula);
	}
}