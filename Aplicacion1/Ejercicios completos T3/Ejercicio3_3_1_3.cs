/*Ejercicio 3.3.1.3: Crea un programa que pida al usuario el ancho (por ejemplo, 4) y 
el alto(por ejemplo, 3) y una letra (por ejemplo, X) y escriba un rectángulo formado por
esa cantidad de letras*/
using System;
public class Ejercicio3_3_1_3
{
	public static void Main()
	{
		char letra;
		int dalto, dancho;
		Console.Write("¿Alto?: ");
		dalto = Convert.ToInt32(Console.ReadLine());
		Console.Write("¿Ancho?: ");
		dancho = Convert.ToInt32(Console.ReadLine());
		Console.Write("¿Letra?: ");
		letra = Convert.ToChar(Console.ReadLine());
		for(int alto = 1; alto <= dalto; alto++)
		{
			for(int ancho = 1; ancho <= dancho - 1; ancho++)
			{
				Console.Write(letra);
				if(ancho == dancho - 1)
				{
					Console.WriteLine(letra);
				}
			}
		}
	}
}