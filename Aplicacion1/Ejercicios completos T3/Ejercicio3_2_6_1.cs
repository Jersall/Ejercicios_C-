/*Ejercicio 3.2.6.1: Crea un programa que pida números (base 10) al 
usuario y muestre su equivalente en el sistema binario y en hexadecimal
(Y en octal, ya que estamos). Que se repita hasta que el usuario introduzca el numero 0.*/
using System;
public class Ejercicio3_2_6_1
{
	public static void Main()
	{
		int n;
		Console.Write("Introduce un numero entero: ");
		n = Convert.ToInt32(Console.ReadLine());
		Console.Write("{0}(hex) = ", n);
		Console.WriteLine(Convert.ToString(n, 16));
		Console.Write("{0}(binario) = ", n);
		Console.WriteLine(Convert.ToString(n, 2));
		Console.Write("{0}(octal) = ", n);
		Console.WriteLine(Convert.ToString(n, 8));
	}
}