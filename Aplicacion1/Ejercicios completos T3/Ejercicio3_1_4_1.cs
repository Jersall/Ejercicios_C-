/*Ejercicio 3.1.4.1: Crea un programa que use las variables x, y y z, cuyos valores 
serán de 15, -10 y 214. Incrementa el valor de estas variables en 12 usando el formato 
abreviado. ¿Que valores esperas obtener? Contrástalo con el resultado obtenido.*/
/*Valor esperado: Simple cual ejercicio de aumentar valores en 12: 
15 = 27, -10 = 2, 214 = 226*/
using System;
public class Ejercicio3_1_4_1
{
	public static void Main()
	{
		int n1 = 15, n2 = -10, n3 = 214;
		Console.WriteLine("X = {0}, Y = {1}, Z = {2}", n1, n2, n3);
		n1 += 12;
		n2 += 12;
		n3 += 12;
		Console.WriteLine("+ 12");
		Console.WriteLine("X = {0}, Y = {1}, Z = {2}", n1, n2, n3);

	}
}