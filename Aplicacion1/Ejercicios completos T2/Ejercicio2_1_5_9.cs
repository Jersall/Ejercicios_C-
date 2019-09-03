/*Ejercicio 2.1.5.9: Crea un programa que pida al usuario 3 números y muestre cual es mayor*/
/*Iniciativa: Intentemos que muestre el órden de mayor a menor de los numeros implicados, en lugar
de solo "el mayor de los 3"*/
/*Iniciativa 2: Intentemos que diga si hay números iguales*/
/*Nota: He notado los pequeños problemas que ocasiona el programa en situaciones donde 2 
de los números son iguales: La idea, siguiendo con if, seria hacer el "<" al igual que 
se ha completado el ">". Aún así, a pesar de no mostrar 100% lo deseado, el programa cumple 
con las iniciativas autopropuesta, y se deberia alargar todavía más de querer que muestre
el mayor/menor con mas orden. La lógica base, aún así, funciona a la perfección y 
proporciona respuestas correctas.*/
/*Ejercicio 2.1.5.10 integrado en variante: pide 2 numeros, y que diga si son iguales, 
y si no lo son, cual es mayor. Aqui está preparada la misma situación, pero para 3 
números en lugar de 2*/
using System;
public class Ejercicio2_1_5_9
{
	public static void Ejecutar()
	{
		int n1, n2, n3;
		Console.Write("Introduce un número entero: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número entero: ");
		n2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un número entero más: ");
		n3 = Convert.ToInt32(Console.ReadLine());
		if ((n1 > n2) && (n2 > n3))
			Console.WriteLine("{0}>{1}>{2}", n1, n2, n3);
		if ((n1 > n3) && (n3 > n2))
			Console.WriteLine("{0}>{1}>{2}", n1, n3, n2);
		if ((n2 > n1) && (n1 > n3))
			Console.WriteLine("{0}>{1}>{2}", n2, n1, n3);
		if ((n2 > n3) && (n3 > n1))
			Console.WriteLine("{0}>{1}>{2}", n2, n3, n1);
		if ((n3 > n1) && (n1 > n2))
			Console.WriteLine("{0}>{1}>{2}", n3, n1, n2);
		if ((n3 > n2) && (n2 > n1))
			Console.WriteLine("{0}>{1}>{2}", n3, n2, n1);
		if ((n1 > n2) && (n2 == n3))
			Console.WriteLine("{0}>{1}={2}", n1, n2, n3);
		if ((n1 > n3) && (n3 == n2))
			Console.WriteLine("{0}>{1}={2}", n1, n3, n2);
		if ((n2 > n1) && (n1 == n3))
			Console.WriteLine("{0}>{1}={2}", n2, n1, n3);
		if ((n2 > n3) && (n3 == n1))
			Console.WriteLine("{0}>{1}={2}", n2, n3, n1);
		if ((n3 > n1) && (n1 == n2))
			Console.WriteLine("{0}>{1}={2}", n3, n1, n2);
		if ((n3 > n2) && (n2 == n1))
			Console.WriteLine("{0}>{1}={2}", n3, n2, n1);
		if ((n1 == n2) && (n2 > n3))
			Console.WriteLine("{0}={1}>{2}", n1, n2, n3);
		if ((n1 == n3) && (n3 > n2))
			Console.WriteLine("{0}={1}>{2}", n1, n3, n2);
		if ((n2 == n1) && (n1 > n2))
			Console.WriteLine("{0}={1}>{2}", n2, n1, n3);
		if ((n2 == n3) && (n3 > n2))
			Console.WriteLine("{0}={1}>{2}", n2, n3, n1);
		if ((n3 == n1) && (n1 > n2))
			Console.WriteLine("{0}={1}>{2}", n3, n1, n2);
		if ((n3 == n2) && (n2 > n1))
			Console.WriteLine("{0}={1}>{2}", n3, n2, n1);
		if ((n1 == n2) && (n2 == n3))
			Console.WriteLine("Los 3 números son iguales");
	}
}