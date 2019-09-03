/*Ejercisu de Monedisu de Caamañisu: Pedir 3 valores: 2 importes y 1 tipo de moneda. 
Con los tres valores, se realizará la suma en pantalla  de los importes con un texto: 
"El precio total asciende a {Resultado}{Tipo de moneda}"*/
using System;
public class Ejercisu_Caamañisu_Temisu_1
{
	public static void Main()
	{
		int n1, n2, resul;
		char moneda;
		Console.Write("Introduce el primer importe: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce el tipo de divisa: ");
		moneda = Convert.ToChar(Console.ReadLine());
		Console.Write("Introduce el segundo importe: ");
		n2 = Convert.ToInt32(Console.ReadLine());
		resul = n1 + n2;
		Console.WriteLine("El precio total es de {0} {1}, Grasias por su visita", 
			resul, moneda);
	}
}