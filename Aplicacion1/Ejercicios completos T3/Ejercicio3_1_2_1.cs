/*Ejercicio 3.1.2.1: Pregunta al usuario su edad, que se guardara en una variable byte.
A continuación, le deberás decir que miente, que no tiene esa edad.*/
using System;
public class Ejercicio3_1_2_1
{
	public static void Ejecutar()
	{
		byte edad;
		Console.Write("¿Edad?: ");
		edad = Convert.ToByte(Console.ReadLine());
		Console.WriteLine("¡MENTIRA! ¡Tu no tienes {0} años!", edad);
	}
}