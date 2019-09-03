/*Ejercicio 2.1.5.1: Crea un programa que pida al usuario 
un número entero y responda si es múltiple de 2 o de 3*/
/*Ejercicio 2.1.5.2: Crea un programa que pida al usuario 
un numero y diga si es multiplo de 2 y 3 simultaneamente*/
/*Ejercicio 2.1.5.3: Crea un programa que responda si es multiple de 2 pero no de 3*/
/*Ejercicio 2.1.5.4: Que responda si no son multiples de ninguno de los 2 numeros*/
using System;
public class Ejercicio2_1_5_1
{
	public static void Ejecutar()
	{
		int n1, m2, m3;
		Console.Write("Introduce un número entero, ¿Será múltiple de 2 o 3?: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		m2 = 2;
		m3 = 3;
		if ((n1 % m2 == 0) || (n1 % m3 == 0))
		{		
				if ((n1 % m2 == 0) && (n1 % m3 == 0))
					Console.WriteLine("Este número es múltiple de 2 y 3");
				else 
					if (n1 % m2 == 0)
					Console.WriteLine("Este número es múltiple de 2, pero no de 3");
					else 
					Console.WriteLine("Este número es múltiple de 3, pero no de 2");
		}			
		else Console.WriteLine("Este número no es múltiple ni de 2 ni de 3");
	}
}
