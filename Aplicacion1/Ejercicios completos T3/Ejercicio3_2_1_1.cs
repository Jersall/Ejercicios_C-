/*Ejercicio 3.2.1.1: Crea un programa que muestre el resultado de dividir 3 entre 4 
usando números enteros y luego usando números de coma flotante*/
using System;
public class Ejercicio3_2_1_1
{
	public static void Ejecutar()
	{
		int n1 = 3, n2 = 4, d1 = n1 / n2;
		float n3 = 3, n4 = 4, d2 = n3 / n4;
		Console.WriteLine("{0} / {1} = ", n1, n2);
		Console.Write("{0}(int), {1}(float)", d1, d2);
	}
}