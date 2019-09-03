/*Ejercicio 3.1.3.2: ¿Cual seria el resultado de las siguientes operaciones?:
a = 5; b = ++a; c=a++; b = b * 5; a = a * 2
Calcula a mano, y luego crea un programa que lo resuelva, para comprobar si lo has hecho
correctamente a mano.*/

//Ejercicio a mano:
//a = 5 -> b = a + 1(6) -> c = 6, a = 7 -> b = b * 5 = 30 -> a = a * 2 = 14
//Conclusión: a = 14, b = 30, c = 6

//programa:
using System;
public class Ejercicio3_1_3_2
{
	public static void Ejecutar()
	{
		int a, b, c;
		a = 5;
		b = ++a;
		c = a++;
		b = b * 5;
		a = a * 2;
		Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
	}
}
//Comprobando resultado: Correcto. Clavao. Soy un crack.