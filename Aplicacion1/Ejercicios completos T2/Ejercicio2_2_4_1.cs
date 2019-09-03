/*Ejercicio 2.2.4.1: Crea un bucle sin fin que escriba la palabra "hola" sin avanzar de línea.*/
using System;
public class Ejercicio2_2_4_1
{
	public static void Ejecutar()
	{
		int contador;
		for (contador = 1; contador != 0; )
			Console.Write("Hola ");
	}
}