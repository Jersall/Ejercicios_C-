/*Ejercicio 3.4.1: Crea un programa que pida al usuario su nombre, y le diga "Hola" 
si se llama Juanjo, o bien le diga "no te conozco" de decir otro nombre.*/
using System;
public class Ejercicio3_4_1
{
	public static void Ejecutar()
	{
		string nombre;
		Console.Write("¿Quien eres? ¿Cual es tu nombre?: ");
		nombre = Convert.ToString(Console.ReadLine());
		if (nombre == "Juanjo")
		{
			Console.WriteLine("¡Ah! ¡Hola {0}!", nombre);
		}
		else
		{
			Console.WriteLine("Yo a ti no te conozco, {0}", nombre);
		}
	}
}