/*Ejercicio 2.2.1.2.3: Crea un programa que calcule cuántas cifras tiene 
un número entero positivo(Pista: Se puede hacer dividiendo varias veces entre 10*/
using System;
public class Ejercicio2_2_1_2_3
{
	public static void Main()
	{
		int ntecla, ncuenta, nmuestra;
		Console.Write("Introduce un número entero: ");
		ntecla = Convert.ToInt32(Console.ReadLine());
		nmuestra = ntecla;
		ncuenta = 0;
		while(ntecla != 0)
		{
			ntecla = ntecla / 10;
			ncuenta = ncuenta + 1;
		}
		Console.WriteLine("{0} tiene {1} números de largo", nmuestra, ncuenta);
	}
}