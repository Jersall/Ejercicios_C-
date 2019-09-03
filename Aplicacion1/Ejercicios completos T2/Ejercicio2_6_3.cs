/*Ejercicio 2.6.3: Crea un programa que pida un numero y lo eleve a otro, 
usando multiplicaciones sucesivas.*/
using System;
public class Ejercicio2_6_3
{
	public static void Main()
	{
		double n1, ele, pot;
		Console.Write("Introduce un número entero: ");
		n1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Introduce la potencia a la que vas a elevar el número: ");
		ele = Convert.ToDouble(Console.ReadLine());
		pot = n1;
		Console.WriteLine("{0} ^ {1} = ", pot, ele);
		Console.Write("{0} · {0} = ", n1);
		for (double r = ele - 1; r > 0; r--)
		{
			n1 = n1 * pot;
			Console.WriteLine("{0}", n1);
			if (r > 1)
			Console.Write("{0} · {1} = ", n1, pot);			
		}
	}	
}