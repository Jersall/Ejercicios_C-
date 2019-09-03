/*Ejercicio 2.2.1.1.3: Crea un programa que pida de forma repetitiva pares de números. 
Tras introducir los números el programa dirá si el primero es múltiplo del segundo.*/
/*using System;
public class Ejercicio2_2_1_1_3
{
	public static void Ejecutar()
	{
		int n1, n2;
		Console.Write("Introduce un número entero: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		n2 = 0;		
		while(n1 != 0)
		{
			Console.Write("Introduce otro número entero: ");
			n2 = Convert.ToInt32(Console.ReadLine());
			if (n2 % n1 == 0)
				Console.WriteLine("{0} es múltiple de {1}", n1, n2);
			else Console.WriteLine("{0} no es múltiple de {1}", n1, n2);
			Console.Write("Introduce un número entero: ");
			n1 = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("¡Hasta otra!");
	}
}*/
/*Ejercicio 2.2.1.1.4: Mejora el programa anterior para que, tras introducir cada par de números 
responderá si el primero es múltiplo del segundo, o el segundo es múltiplo del primero, 
o ninguno de ellos lo es.*/
using System;
public class Ejercicio2_2_1_1_4
{
	public static void Ejecutar()
	{
		int n1 = 1, n2 = 0;		
		while(n1 != 0)
		{
			Console.Write("Introduce un número entero: ");
			n1 = Convert.ToInt32(Console.ReadLine());
			if(n1 != 0)
			{
				Console.Write("Introduce otro número entero: ");
				n2 = Convert.ToInt32(Console.ReadLine());
				if((n1 % n2 == 0) && (n2 % n1 == 0))
					Console.WriteLine(
						"Evidentemente, {0} es múltiple de {1}... por que son el mismo número", 
						n1, n2);
				else
				{
					if(n1 % n2 == 0)
						Console.WriteLine("{0} es múltiple de {1}.", n1, n2);
					if(n2 % n1 == 0)
						Console.WriteLine("{0} es múltiple de {1}.", n2, n1);
					if((n1 % n2 != 0) && (n2 % n1 != 0))
						Console.WriteLine(
							"Los números no son múltiples de ningún modo no-decimal."
							);
				}
			}
			else Console.WriteLine("¡Hasta otra!");
		}
	}
}