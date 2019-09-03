/*Ejercicio 3.2.5.3: Calcula el perimetro, area y diagonal de un rectángulo a partir de 
su ancho y alto(Perimetro = base · 2 + altura · 2) 
área(base · altura) 
y diagonal(base^2 · altura^2)
Muestra todos ellos con una sola cifra decimal.*/
using System;
public class Ejercicio3_2_5_3
{
	public static void Ejecutar()
	{
		float dancho, dalto, perimetro, area, diagonal;
		Console.Write("¿Ancho?(cm): ");
		dancho = Convert.ToSingle(Console.ReadLine());
		Console.Write("¿Alto?(cm): ");
		dalto = Convert.ToSingle(Console.ReadLine());
		perimetro = dancho * 2 + dalto * 2;
		Console.Write("Perimetro = ");
		Console.Write(perimetro.ToString("#.#"));
		Console.WriteLine(" cm");
		area = dancho * dalto;
		Console.Write("Área = ");
		Console.Write(area.ToString("#.#"));
		Console.WriteLine(" cm^2");
		dancho *= dancho;
		dalto *= dalto;
		diagonal = dancho * dalto;
		diagonal = (float) Math.Sqrt(diagonal);
		Console.Write("Diagonal = ");
		Console.Write(diagonal.ToString("#.#"));
		Console.WriteLine(" cm");
	}
}