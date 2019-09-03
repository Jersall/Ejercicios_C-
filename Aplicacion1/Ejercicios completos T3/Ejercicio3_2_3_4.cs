/*Ejercicio 3.2.3.4: Si se ingresan E euros en el banco a un cierto interés I durante 
N años, el dinero obtenido viene dado por la formula de interés compuesto: 
resultado = E · (1 + I)^N. 
Aplicarlo en cuanto se convierten 1000 euros al cabo de 10 años al 3% del interes anual.*/
using System;
public class Ejercicio3_2_3_4
{
	public static void Main()
	{
		decimal euros = 1000, interes = 3, aos = 10, resultado, elev;
		interes++;
		elev = interes;
		for (decimal i = aos; i > 0; i--)
		{
			interes *= elev;
		}
		resultado = euros * interes;
		Console.WriteLine(resultado);
	}
}