/*Ejercicio 1.11.4: Crea un programa que convierta grados Celsius a Kelvin y Fahrenheit: 
pedirá al usuario la cantidad de ºC y usara las siguientes tablas de conversión: 
(ºK = ºC + 273);
(ºF = ºC x 18 / 10 + 32);
Usa "Write" en lugar de "{n}"*/
using System;
public class Ejercicio1_11_4
{
	public static void Ejecutar()
	{
		int oc;
		Console.Write("Introduce ºC. Se convertirá la cantidad a ºK y ºF, respectivamente: ");
		oc = Convert.ToInt32(Console.ReadLine());
		int ok = oc + 273, of = ((oc * 18) / 10) + 32;
		Console.Write(oc);
		Console.Write(" ºC = ");
		Console.Write(ok);
		Console.Write(" ºK = ");
		Console.Write(of);
		Console.WriteLine(" ºF");
	}
}