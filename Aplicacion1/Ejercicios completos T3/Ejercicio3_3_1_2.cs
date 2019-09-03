/*Ejercicio 3.3.1.2:  Crea un programa que muestre una de cada dos letras entre la 
que teclee el usuario y la "z". Por ejemplo, si el usuario introduce una "a", se escribirá
"aceg...".*/
using System;
public class Ejercicio3_3_1_2
{
	public static void Main()
	{
		char letra;
		Console.Write("¿Letra?: ");
		letra = Convert.ToChar(Console.ReadLine());
		int nlet = Convert.ToInt32(letra);
		for (int i = nlet; i <= 121; i += 2)
		{
			Console.Write(Convert.ToChar(i));
			Console.Write(", ");
			if (i + 2 >= 122)
			{
				Console.WriteLine("z");
			}
		}	
	}
}