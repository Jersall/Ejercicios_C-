/*Ejercicio 2.1.9.3: Crea un programa que lea una letra tecleada por el usuario y 
diga si se trata de una vocal, un número o una consonante*/
using System;

public class Ejercicio2_1_9_3
{
	public static void Ejecutar()
	{
		char alfanum;
		Console.Write("Introduce una letra, o numero(Solo 1): ");
		alfanum = Convert.ToChar(Console.ReadLine());
		switch (alfanum)
		{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u': Console.WriteLine("Vocal.");
		break;
			case 'b':
			case 'c':
			case 'd':
			case 'f':
			case 'g':
			case 'h':
			case 'j':
			case 'k':
			case 'l':
			case 'm':
			case 'n':
			case 'ñ':
			case 'p':
			case 'q':
			case 'r':
			case 's':
			case 't':
			case 'v':
			case 'w':
			case 'x':
			case 'y':
			case 'z': Console.WriteLine("Consonante.");
		break;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9': Console.WriteLine("Número.");
		break;
			default: Console.WriteLine("Eso es un símbolo de aritmética, de informática o de puntuacion. O un espacio. Odio cuando intentan colarme espacios.");
		break;
		}
	}
}
