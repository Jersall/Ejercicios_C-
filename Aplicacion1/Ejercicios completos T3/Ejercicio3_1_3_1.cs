/*Ejercicio 3.1.3.1: Crea un programa que use 3 variables. 
Sus valores iniciales serán de 15, -10 y 2147483647.
Se deberá incrementar el valor de estas variables.
¿Que valores esperas que se obtengan? Contrástalo con el resultado obtenido 
por el programa*/
using System;
public class Ejercicio3_1_3_1
{
	public static void Main()
	{
		byte quince = 15;
		sbyte mdiez = -10;
		long muchonum = 2147483647;
		/*En teoría, con un ++ deberia ser cualquiera de las 3 +1: 16, -9, 2147483648. Veamos.*/
		Console.Write("{0} ", quince);
		quince++;
		Console.WriteLine(quince);
		Console.Write("{0} ", mdiez);
		mdiez++;
		Console.WriteLine(mdiez);
		Console.Write("{0} ", muchonum);
		muchonum++;
		Console.WriteLine(muchonum);
	}
}