/*Ejercicio 2.1.3.1: Crea un programa que multiplique 2 numeros enteros de la siguiente forma:
-Pedirá un numero
-Si el numero es 0, mostrara la frase "El producto de 0 por cualquier numero es 0"
-Si es otro numero, pedirá un segundo numero para la operación.*/
/*+Ejercicio2.1.4.1: Mejora el ejercicio con "else"*/
using System;
public class Ejercicio2_1_3_1
{
	public static void Ejecutar()
	{
		int n1, n2, prod;
		Console.Write("Introduce un número a multiplicar: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		if (n1 != 0)
		{
			Console.Write("Introduce un segundo número: ");
			n2 = Convert.ToInt32(Console.ReadLine());
			prod = (n1 * n2);
			if (n2 != 0)
				Console.WriteLine("{0} x {1} = {2}", n1, n2, prod);
			else Console.WriteLine("El producto de cualquier multiplicación con un 0 es igual a 0");
		}
		else Console.WriteLine("El producto de cualquier multiplicación con un 0 es igual a 0");
	}
}