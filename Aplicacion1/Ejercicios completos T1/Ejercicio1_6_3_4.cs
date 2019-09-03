//Ejercicio 1.5.2.1: Calcular el resultado de -2+3*5, 1.6.2.1: Ampliar el ejercicio con variables en la misma línea y tengan valores iniciales.
//Ejercicio 1.6.3.4: Ampliar el ejercicio 1.6.2.1(mod 1.5.2.1) para que muestre la operación n1+n2*n3
public class Ejercicio1_6_2_1
{
	public static void Main()
	{
		int N1 = -2, N2 = 3, N3 = -5;
		int ope = N1 + N2 * N3;
		System.Console.WriteLine("El resultado de la operación {0}+{1}*{2} es de {3}", N1, N2, N3, ope);
	}
}