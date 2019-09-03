/*Ejercicio 3.2.4.1: Crea un programa que calcule la raiz cuadrada del numero 
que introduzca el usuario. La raíz se debera calcular como double pero el 
resultado se mostrará como float*/
using System;
public class Ejercicio3_2_4_1
{
	public static void Main()
	{
		int n1;
		double raiz;
		float raizsimple;
		Console.Write("¿Numero para raiz?: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		raiz = Math.Sqrt(n1);
		raizsimple = (float) raiz;
		Console.WriteLine("La raíz cuadrada de {0} es de {1}", n1, raizsimple);
	}
}