/*EjercicioI2: Existe una norma no escrita en los baños públicos para hombres: 
Nunca pueden haber 2 hombres en 2 urinarios contiguos. Siempre debe dejarse un 
urinario libre en ambas direcciones, dejando un patrón de ocupado-vacio-ocupado-vacio-ocupado.
Basándote en esta norma, crea un programa que pida al usuario el numero de 
urinarios disponibles y crea un algoritmo para que devuelva el número máximo 
de hombres que pueden estar a la vez meando cumpliendo esa norma.*/
using System;
public class EjercicioI2
{
	public static void Ejecutar()
	{
		int urinarios, hombres;
		Console.Write("Introduce el número de urinarios.");
		urinarios = Convert.ToInt32(Console.ReadLine());
		hombres = urinarios / 2;
		if (urinarios % hombres == 0)
			Console.WriteLine("Caben {0} hombres sin molestarse.", hombres);
		if (urinarios % hombres == 1)
			{
				hombres = urinarios / 2 + 1;
				Console.WriteLine("Caben {0} hombres sin molestarse.", hombres); 
			}
	}
}