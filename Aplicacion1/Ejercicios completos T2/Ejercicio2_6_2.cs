/*Ejercicio 2.6.2:Crea un programa que descomponga un número que teclee el usuario 
como producto de sus factores primos. Por ejemplo: 60 = 2·2·3·5*/
/*using System;
public class Ejercicio2_6_2
{
	public static void Ejecutar()
	{
		int entero, primo = 2;
		Console.Write("Introduce un número entero. Lo descompondré en factores primos: ");
		entero = Convert.ToInt32(Console.ReadLine());
		Console.Write("El número {0} es igual a: ", entero);
		while (entero > 1)
		{	
			if (entero % primo == 0)
			{	
				entero = entero / primo;
				if (entero == 1)
					Console.WriteLine("{0}", primo);
				else
				{
					Console.Write("{0} · ", primo);
					primo = 2;
				}
			}
			else
				primo++;
		}		
	}
}*/
using System;
public class Ejercicio2_6_2
{
	public static void Ejecutar()
	{
		int entero, primo = 2;
		Console.Write("Introduce un número entero. Lo descompondré en factores primos: ");
		entero = Convert.ToInt32(Console.ReadLine());
		Console.Write("{0} = ", entero);
		while (entero != primo) 
		{	
			if ((entero % primo == 0) && (entero != primo))
			{	
				entero = entero / primo;
				Console.Write("{0} · ", primo);
				primo = 2;			
			}
			else
				primo++;
			if (entero == primo)
				Console.WriteLine("{0}", primo);	
		}		
	}
}