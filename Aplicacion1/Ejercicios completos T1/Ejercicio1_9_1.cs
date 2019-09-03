/*Ejercicio 1.9.1: Crea un programa que calcule el producto de dos numeros introducidos por el usuario.*/
public class Ejercicio1_9_1
{
	public static void Ejecutar()
	{
		int n1, n2, prod;
		System.Console.WriteLine("Introduce un dígito");
			n1 = System.Convert.ToInt32
			(
				System.Console.ReadLine()
			);
		System.Console.WriteLine("Introduce un segundo dígito");
			n2 = System.Convert.ToInt32
			(
				System.Console.ReadLine()
			);
		prod = n1 * n2;
		System.Console.WriteLine("El producto de la multiplicación de {0}*{1} es de {2}", n1, n2, prod);
	}
}