/*Ejercicio 3.2.5.2: Crea un programa que use tres variables(XYZ). Las tres serán numeros 
reales, y nos bastará con dos cifras decimales(Como minimo). Se deberá pedir al usuario 
los valores de las 3 variables y mostrar en pantalla el valor de:
 ¡¡X^2+Y-Z!!
con exactamente dos cifras decimales.*/
using System;
public class Ejercicio3_2_5_2
{
	public static void Ejecutar()
	{
		float n1, n2, n3, operasao;
		Console.WriteLine("Con dos decimales minimo. Usa ','");
		Console.Write("¿N1?: ");
		n1 = Convert.ToSingle(Console.ReadLine());
		Console.Write("¿N2?: ");
		n2 = Convert.ToSingle(Console.ReadLine());
		Console.Write("¿N3?: ");
		n3 = Convert.ToSingle(Console.ReadLine());
		operasao = n1 * n1 + n2 - n3;
		Console.WriteLine(operasao.ToString("#.##"));
	}
}