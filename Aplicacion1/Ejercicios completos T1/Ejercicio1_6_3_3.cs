//Ejercicio 1.6.3.3: Crea un programa que calcule el resto de dividir 3784 entre 16 con variables
public class Ejercicio1_6_3_3
{
	public static void Ejecutar()
	{
		int n1 = 3784, n2 = 16;
		int residuo = n1 % n2;
		System.Console.WriteLine("El residuo de la división de {0} entre {1} es de {2}", n1, n2, residuo);
	}
}