/*Ejercicio 3.2.3.2: Crea un programa que pida al usuario una distancia en metros 
y el tiempo necesario para recorrerla(en horas, minutos y segundos) y muestre 
la velocidad en m/s, km/h y millas/h(1milla = 1609m) v = s/t*/
using System;
public class Ejercicio3_2_3_2
{
	public static void Ejecutar()
	{
		float metros, metroseg, km, kmh, millas, millash;
		int hors, mins, segs;
		Console.Write("¿Metros?: ");
		metros = Convert.ToSingle(Console.ReadLine());
		Console.Write("¿Horas?: ");
		hors = Convert.ToInt32(Console.ReadLine());
		Console.Write("¿Minutos?: ");
		mins = Convert.ToInt32(Console.ReadLine());
		Console.Write("¿Segundos?: ");
		segs = Convert.ToInt32(Console.ReadLine());
		while (hors > 0)
		{
			mins += 60;
			hors--;
		}
		while (mins > 0)
		{
			segs += 60;
			mins--;
		}
		metroseg = metros / segs;
		Console.WriteLine("{0} m/s", metroseg);
		hors = segs / 3600;
		km = metros / 1000;
		kmh = km / hors;
		Console.WriteLine("{0} km/h", kmh);
		millas = metros / 1609;
		millash = millas / hors;
		Console.WriteLine("{0} mph", millash);
	}
}