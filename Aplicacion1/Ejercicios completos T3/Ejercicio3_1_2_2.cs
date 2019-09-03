/*Ejercicio 3.1.2.2: Pide al usuario dos numeros de dos cifras(byte), 
calcula su multiplicación, que se deberá guardar en un ushort. 
Muestra el resultado en pantalla.*/
using System;
public class Ejercicio3_1_2_2
{
	public static void Main()
	{
		byte n1, n2;
		Console.Write("¿Numero 1?(max 2 cifras): ");
		n1 = Convert.ToByte(Console.ReadLine());
		Console.Write("¿Numero 2?(Max 2 cifras): ");
		n2 = Convert.ToByte(Console.ReadLine());
		ushort producto = Convert.ToUInt16(n1 * n2);
		Console.WriteLine("{0} · {1} = {2}", n1, n2, producto);
	}
}