/*Ejercicio 2.6.1: Crea un programa que de al usuario la oportunidad de adivinar un 
numero del 1 al 100(prefijado) en un maximo de 6 intentos. En cada pasada deberá avisar de si se ha pasado, o quedado corto.*/
using System;
public class Ejercicio2_6_1
{
	public static void Main()
	{
		int adivina, intentos = 6, respuesta = 91;
		Console.Write("A ver si adivinas el número. De 1 a 100. Te doy 6 intentos: ");
		do
		{
			adivina = Convert.ToInt32(Console.ReadLine());
			if(adivina != respuesta)
			{
				intentos--;
				Console.Write("Te quedan {0} intentos. ", intentos);
				if (adivina > respuesta)
				{
					Console.WriteLine("{0} es demasiado, prueba a bajar un poco", adivina);
				}
				if (adivina < respuesta)
				{
					Console.WriteLine("{0} es demasiado poco, prueba a subir", adivina);
				}
				if ((adivina > 100) || (adivina < 1))
				{
					Console.WriteLine("te he dicho de 1 a 100, colega, esto te lo cuento como intento, por listillo.");
				}
			}
		}
		while((adivina != respuesta) && (intentos != 0));
		
		if (intentos == 0)
			Console.WriteLine("Te quedaste sin intentos.");
		else
			Console.WriteLine("¡Correcto!");
	}
}