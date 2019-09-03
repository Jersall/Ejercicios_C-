/*Ejercicio 2.1.9.2: Crea un programa que lea una tecla tecleada por el usuario y diga si se trata de un signo de puntuación, una cifra numérica o algún otro caracter, usando switch.*/
using System;
public class Ejercicio2_1_9_2
{
	public static void Main()
	{
		char tecla;
		Console.Write("Escribe un solo caracter: ");
		tecla = Convert.ToChar(Console.ReadLine());
		switch (tecla)
		{
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case '0': Console.WriteLine("¡Dígito!");
		break;
			case ' ': Console.WriteLine("Eso, amigo mío, es un espacio.");
		break;
			case 'º':
			case 'ª':
			case '!':
			case '"':
			case '@':
			case '·':
			case '#':
			case '$':
			case '~':
			case '%':
			case '&':
			case '¬':
			case '/':
			case '(':			
			case ')':
			case '=':
			case '?':
			case '¿':
			case '¡':
			case '<':
			case '>':
			case ',':
			case ';':
			case ':':
			case '.':
			case '_':
			case '-':
			case '´':
			case '¨':
			case '{':
			case '}':
			case '^':
			case '`':
			case '[':
			case ']':
			case '+':
			case '*':
			case '€': Console.WriteLine("Esto es un símbolo de tu teclado, signo de puntuación o empleado en aritmética.");
		break;
			default: Console.WriteLine("Eso tiene pinta de letra."); 
		break;	
		}
	}
}