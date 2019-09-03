/*Ejercicio 2.6.8: Crea un programa que devuelva el cambio de una compra utilizando 
monedas o billetes del mayor valor posible(500, 200, 100, 50, 20, 10, 5, 2, 1)*/
using System;
public class Ejercicio2_6_8
{
	public static void Main()
	{
		int precio, pagado, cambio, billete = 500;
		Console.Write("¿Precio?: ");
		precio = Convert.ToInt32(Console.ReadLine());
		Console.Write("¿Pagado?: ");
		pagado = Convert.ToInt32(Console.ReadLine());
		cambio = pagado - precio;
		while (cambio > 0)
		{
			if (billete < cambio)
			{
				Console.Write("{0} + ", billete);
				cambio = cambio - billete;
				billete = 500;
			}
			else
			{				
				switch(billete)
				{
					case 2: billete = 1;
					break;
					case 5: billete = 2;
					break;
					case 10: billete = 5;
					break;
					case 20: billete = 10;
					break;
					case 50: billete = 20;
					break;
					case 100: billete = 50;
					break;
					case 200: billete = 100;
					break;
					case 500: billete = 200;
					break;
					default: Console.WriteLine();
					break;
				}
			}
			if (cambio - billete == 0)
			{
				Console.WriteLine(billete);
				cambio = cambio - billete;
			}
		}
	}
}