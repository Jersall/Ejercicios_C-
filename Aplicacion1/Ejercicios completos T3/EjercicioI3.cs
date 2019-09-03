/*Ejercicio I3: Crea un programa que pida al usuario un número, éste 
servirá para comprobar la extensión de una sucesión de fibonacci(8 = 8 consecuciones)*/

/*La sucesión de fibonacci: es una secuencia de numeros infinita de numeros naturales 
que comienza con los numeros 1 y 1. A partir de ellos, cada termino se obtiene sumando los 
dos anteriores: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, etc.*/
using System;
public class EjercicioI3
{
	public static void Main()
	{
		int n1 = 1, n2 = 1, iguala, sucesion;
		Console.Write("¿Cuántos numeros alargamos la fibonacci?(Sin contar los primeros 1): ");
		sucesion = Convert.ToInt32(Console.ReadLine());
		Console.Write("{0}, {1}, ", n1, n2);
		iguala = n1 + n2;
		for (int i = 1; i <= sucesion - 1 ; i++)
		{			
			Console.Write("{0}, ", iguala);
			if (n1 <= n2)
			{
				n1 = iguala;
			}
			else
			{
				n2 = iguala;
			}
			iguala = n1 + n2;
			if (i == sucesion - 1)
			{
				Console.WriteLine("{0}", iguala);
			}	
		}
	}
}