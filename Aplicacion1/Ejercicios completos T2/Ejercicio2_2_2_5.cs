/*Ejercicio 2.2.2.5: Crea un programa que pida al usuario su identificador y su contraseña, 
y que no le permita seguir hasta que introduzca como nombre "Pedro" y como contraseña "Peter"*/
using System;
public class Ejercicio2_2_2_5
{
	public static void Ejecutar()
	{
		string iden, pass;
		do
		{
			Console.Write("Introduce el usuario: ");
			iden = Convert.ToString(Console.ReadLine());
			Console.Write("Introduce la contraseña: ");
			pass = Convert.ToString(Console.ReadLine());
			if ((iden != "Pedro") || (pass != "Peter"))
				Console.WriteLine("Nombre de usuario o contraseña incorrecto.");
		}
		while ((iden != "Pedro") || (pass != "Peter"));
		Console.WriteLine("Bienvenido.");
	}
}