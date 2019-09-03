/*Ejercicio 1.11.2: Pedir al usuario un número y mostrar su tabla de multiplicar,
usando {0},{1} y {2}.*/
using System;
public class Ejercicio1_11_2
{
	public static void Main()
		{
			int cador, tiplo, res;
			Console.Write("Introduce un número: ");
			cador = Convert.ToInt32(Console.ReadLine());
			tiplo = 0;
			res = cador * tiplo;
			Console.WriteLine("{0}x{1}={2}", cador, tiplo, res);
			tiplo = 1;
			res = cador * tiplo;
			Console.WriteLine("{0}x{1}={2}", cador, tiplo, res);
			tiplo = 2;
			res = cador * tiplo;
			Console.WriteLine("{0}x{1}={2}", cador, tiplo, res);
			tiplo = 3;
			res = cador * tiplo;
			Console.WriteLine("{0}x{1}={2}", cador, tiplo, res);
			tiplo = 4;
			res = cador * tiplo;
			Console.WriteLine("{0}x{1}={2}", cador, tiplo, res);
			tiplo = 5;
			res = cador * tiplo;
			Console.WriteLine("{0}x{1}={2}", cador, tiplo, res);
			tiplo = 6;
			res = cador * tiplo;
			Console.WriteLine("{0}x{1}={2}", cador, tiplo, res);
			tiplo = 7;
			res = cador * tiplo;
			Console.WriteLine("{0}x{1}={2}", cador, tiplo, res);
			tiplo = 8;
			res = cador * tiplo;
			Console.WriteLine("{0}x{1}={2}", cador, tiplo, res);
			tiplo = 9;
			res = cador * tiplo;
			Console.WriteLine("{0}x{1}={2}", cador, tiplo, res);
			tiplo = 10;
			res = cador * tiplo;
			Console.WriteLine("{0}x{1}={2}", cador, tiplo, res);
		}
}