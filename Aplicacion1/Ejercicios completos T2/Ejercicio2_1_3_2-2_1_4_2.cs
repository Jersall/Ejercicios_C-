/*Ejercicio 2.1.3.2: Crea un programa de divisiones que haga lo siguiente:
- Si el divisor no es 0, mostrará la operación.
- Si el divisor es 0, dirá "Error, no es posible dividir entre 0"*/
/*+Ejercicio 2.1.4.2: Mejora el ejercicio con else*/

using System;
public class Ejercicio2_1_3_2
{
	public static void Main()
	{
		int n1, n2;
		Console.Write("Introduce un número entero: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		if (n1 != 0)
		{
			Console.Write("Introduce un segundo número entero: ");
			n2 = Convert.ToInt32(Console.ReadLine());
			if (n2 != 0) 
			{
				if (n1 > n2)
				{
					int coc = n1 / n2;
					int res = n1 % n2;
					Console.WriteLine("{0} / {1} = {2}, {3} residual", n1, n2, coc, res);
				}
				else Console.WriteLine("Error: El divisor no debe ser mayor que el dividendo.");
			}
			else Console.WriteLine("Error: El divisor no puede ser 0.");
		}
		else Console.WriteLine("Error: El dividendo no puede ser 0.");
	}
}
