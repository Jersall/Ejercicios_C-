/*Ejercicio 3.2.5.4: Calcula la superficie y el volumen de una esfera a partir de su radio:
superficie = 4 · pi · r^2
volumen = 4/3 · pi · r^3
Usa datos "doble" y muestra los resultados con 5 cifras decimales.*/
using System;
public class Ejercicio3_2_5_4
{
	public static void Main()
	{
		double radio, super, vol, pi;
		pi = 3.14159;
		Console.Write("¿Radio?(cm): ");
		radio = Convert.ToDouble(Console.ReadLine());
		super = (4 * pi) * (radio * radio);
		Console.Write("Superficie = ");
		Console.Write(super.ToString("N5"));
		Console.WriteLine(" cm");
		vol = ((4 / 3) * pi) * ((radio * radio) * radio);
		Console.Write("Volumen = ");
		Console.Write(vol.ToString("N5"));
		Console.WriteLine(" cm^3");
	}
}