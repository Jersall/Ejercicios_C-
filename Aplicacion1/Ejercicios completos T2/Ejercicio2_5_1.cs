/*Ejercicio 2.5.1: Crea un programa que cuente cuantas veces aparece 
la letra a en una frase que teclee el usuario usando foreach.*/
using System;
public class Ejercicio2_5_1
{
	public static void Ejecutar()
	{
		int contador = 0;
		Console.WriteLine("Escribe una frase, la que quieras:");
		string frase = Console.ReadLine();
		foreach(char letra in frase)
		{
			if (letra == 'a')
			{
				contador++;
			}	
		}
		Console.WriteLine("Hay {0} letras 'a' en esta frase", contador);
	}
}