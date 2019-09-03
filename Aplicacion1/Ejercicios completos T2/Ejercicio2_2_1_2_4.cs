/*Crea un programa que de al usuario 3 oportunidades para adivinar un número del 1 al 10.*/
using System;
public class Ejercicio2_2_1_2_4
{
	public static void Main()
	{
		int res = 7, vidas = 2, tecla;
		Console.Write("Número del 1 al 10, a ver si lo adivinas: ");
		tecla = Convert.ToInt32(Console.ReadLine());
		while ((tecla != res) && (vidas > 0))
		{
			vidas = vidas - 1;
			Console.WriteLine("Fallaste, te quedan {0} intentos", vidas + 1);
			Console.Write("¿Nuevo intento?: ");
			tecla = Convert.ToInt32(Console.ReadLine());
		}
		if (tecla == res)
			Console.WriteLine("¡Correcto!");
		if ((vidas == 0) && (tecla != res))
			Console.WriteLine("Te quedaste sin intentos :(");
	}
}