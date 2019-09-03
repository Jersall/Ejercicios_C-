/*Ejercicio 3.3.1.1:  Crea un programa que pida una letra al usuario y diga si se trata de 
una vocal.*/
using System;
public class Ejercicio3_3_1_1
{
	public static void Ejecutar()
	{
		char letra;
		Console.Write("¿Letra(Solo 1)?: ");
		letra = Convert.ToChar(Console.ReadLine());
		switch (letra)
		{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
				Console.WriteLine("Vocal.");
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
			case 'p':
			case 'q':
			case 'r':
			case 's':
			case 't':
			case 'v':
			case 'w':
			case 'x':
			case 'y':
			case 'z':
				Console.WriteLine("Consonante.");
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
			case '9':
				Console.WriteLine("Numero.");
			break;
			default:
				Console.WriteLine("Solo puede ser un simbolo matemático o de puntuación.");
			break;
		}
	}
}