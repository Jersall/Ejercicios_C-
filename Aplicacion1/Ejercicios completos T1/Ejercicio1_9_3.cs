/*Ejercicio 1.9.3: Suma 3 numeros tecleados por el usuario*/
public class Ejercicio1_9_3
{
	public static void Main()
	{
		int n1, n2, n3, suma;
		System.Console.WriteLine("Introduce un digito");
		n1 = System.Convert.ToInt32
		(
			System.Console.ReadLine()
		);
		System.Console.WriteLine("Introduce un segundo digito");
		n2 = System.Convert.ToInt32
		(
			System.Console.ReadLine()
		);
		System.Console.WriteLine("Introduce un tercer digito");
		n3 = System.Convert.ToInt32
		(
			System.Console.ReadLine()
		);
		suma = n1 + n2 + n3;
		System.Console.WriteLine("{0}+{1}+{2}={3}", n1, n2, n3, suma);
	}
}