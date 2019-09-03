/*Ejercicio 2.7.1: Crea un programa que pregunte al usuario su edad y su año de nacimiento.
Si la edad que introduce no es un número válido, mostrará un mensaje de aviso. 
Lo mismo ocurrirá si el año de nacimiento no es un número valido.
using System;
public class Ejercicio2_7_1
{
	public static void Ejecutar()
	{
		int añonac, edad;
 		try
 		{
 			Console.WriteLine("¿Año de nacimiento?: ");
 			añonac = Convert.ToInt32( Console.ReadLine() );
 			Console.WriteLine("¿Edad?: ");
 			edad = Convert.ToInt32( Console.ReadLine());
 			Console.WriteLine("Año: {0}, edad: {1}", añonac, edad);
 		}
 		catch (Exception errorEncontrado)
 		{
 			Console.WriteLine("Hay un error aqui... {0}", errorEncontrado.Message);
 		}
	}
}

Ejercicio 2.7.2: Que pregunte la edad y el año de nacimiento. 
Que muestre el mensaje de aviso de haber un error, pero que siga 
preguntando hasta el final del programa por el resto de datos.*/

using System;
public class Ejercicio2_7_2
{
	public static void Ejecutar()
	{
		int añonac, edad;
 		try
 		{
 			Console.WriteLine("¿Año de nacimiento?: ");
 			añonac = Convert.ToInt32( Console.ReadLine() );
 			Console.WriteLine("Año: {0}, ", añonac);
 		}
 		catch (Exception errorEncontradouno)
 		{
 			Console.WriteLine("Hay un error aqui... {0}", errorEncontradouno.Message);
 		}
 		try
 		{
 			Console.WriteLine("¿Edad?: ");
 			edad = Convert.ToInt32( Console.ReadLine());
 			Console.WriteLine("edad: {1}", edad);
 		}
 		catch (Exception errorEncontradodos)
 		{
 			Console.WriteLine("Hay un error aqui... {0}", errorEncontradodos.Message);
 		}
	}
}