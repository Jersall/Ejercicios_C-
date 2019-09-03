/*Ejercicio 2.2.2.4: Crea un programa que pida al usuario su identificador y su contraseña, 
ambos numéricos, y no le permita seguir hasta que introduzca como identificador 1234 y la 
contraseña 1111*/
using System;
public class Ejercicio2_2_2_4
{
	public static void Main()
	{
		int iden, pass;
		do
		{
			Console.Write("Introduce el usuario: ");
			iden = Convert.ToInt32(Console.ReadLine());
			Console.Write("Introduce la contraseña: ");
			pass = Convert.ToInt32(Console.ReadLine());
			if ((iden != 1234) || (pass != 1111))
				Console.WriteLine("Usuario o contraseña incorrectos.");
		}
		while ((iden != 1234) || (pass != 1111));
		Console.WriteLine("Bienvenido.");	
	}
}