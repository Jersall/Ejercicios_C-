/*Ejercicio 1.9.2: Crea un programa que calcule la división de dos números 
introducidos por el usuario, asi como el resto de esa división*/

public class Ejercicio1_9_2
{
	public static void Main()
	{
		int n1, n2, cociente, residuo;
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
		cociente = n1 / n2;
		residuo = n1 % n2;
		System.Console.WriteLine("El Cociente de la operación {0}/{1} es de {2}, con {3} como residuo.", n1, n2, cociente, residuo);
	}
}