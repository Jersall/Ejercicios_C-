/*Ejercicio 1.9.4: Pide al usuario una cantidad de millas náuticas y muestra la equivalencia en metros(1=1852)*/
public class Ejercicio1_9_4
{
	public static void Main()
	{
		int naut, metros, conver;
		System.Console.WriteLine("Introduce el número de millas náuticas");
		naut = System.Convert.ToInt32
		(
			System.Console.ReadLine()
		);
		metros = 1852;
		conver = naut * metros;
		System.Console.WriteLine("{0} millas náuticas son {1} metros", naut, conver);
	}
}