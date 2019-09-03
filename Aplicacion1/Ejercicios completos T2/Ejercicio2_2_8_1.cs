/*Ejercicio 2.2.8.1: Crea un programa que escriba 6 lineas de texto, cada una de las cuales
estará formada por numeros del 1 al 7. Debes usar dos variables llamadas "lineas" y "numero", 
y deben estar declaradas dentro del "for"*/
using System;
public class Ejercicio2_2_8_1
{
	public static void Main()
	{
		for (int linea = 1; linea <= 6; linea++)
			for (int numero = 1; numero <= 7; numero++)
				if (numero < 7)
					Console.Write("{0} ", numero);
				else
					Console.WriteLine("{0}", numero);
	}
}