/*Ejercicio 3.2.6.4: Crea un programa que pida numeros binarios al usuario y 
muestre su equivalente en el sistema hex y dec. Debe repetirse hasta que el usuario indique 
la palabra "fin"*/
using System;
public class Ejercicio3_2_6_4
{
	public static void Ejecutar()
	{
		string binario;
		Console.WriteLine("¿Binario?: ");
		binario = Convert.ToString(Console.ReadLine());
		while (binario != "fin")
		{
			Console.Write("Decimal = ");
			Console.WriteLine(Convert.ToInt32(binario, 2));
			int hex = Convert.ToInt32(binario, 2);
			Console.Write("Hex = ");
			Console.WriteLine(Convert.ToString(hex, 16));
			Console.WriteLine("¿Binario?('fin' para terminar): ");
			binario = Convert.ToString(Console.ReadLine());
		}
	}
}