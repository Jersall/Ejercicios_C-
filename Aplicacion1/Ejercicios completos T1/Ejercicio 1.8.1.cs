/*Ejercicio 1.8.1: Crea un programa que convierta una cantidad prefijada de metros(3000) a millas. 
La equivalencia es de 1 milla = 1609 metros. Usa comentarios donde te parezca adecuado.*/

public class Ejercicio1_8_1
{
	public static void Ejecutar()/*Aqui tenemos la base "de fe" de siempre, antes de empezar con el problema directo*/
	{
/*Primero deberíamos introducir nuestra constante Millas, y por otro lado la cantidad de metros.*/
		int metromillas = 1609, metros = 5000, producto = metros / metromillas, res = metros % metromillas;
		/*Y con las variables podemos calcular el conversor en una dirección, con los metros sobrantes al final, para que tengamos una medida... "aproximada"*/
		System.Console.WriteLine("{0} metros, si cada milla son {1} metros, habrian {2} millas, aunque nos sobrarian {3} metros...", metros, metromillas, producto, res);
	}
}