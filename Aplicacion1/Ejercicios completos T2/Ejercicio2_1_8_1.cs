/*Ejercicio 2.1.8.1: Crea un programa que use el operador condicional para mostrar un número de la siguiente forma
- Si el número es positivo, se mostrará sin más
- Si el número es negativo, se cambiará de signo a positivo.*/
/*Nota: No he entendido muy bien el enunciado, asi que esto es lo mas parecido a lo que he entendido.*/
using System;
public class Ejercicio2_1_8_1
{
	public static void Main()
	{
		int n1, cambio;
		Console.Write("Introduce un número: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		cambio = n1 < 0 ? n1 * -1 : n1;
		Console.WriteLine("¡{0}!", cambio);
	}
}