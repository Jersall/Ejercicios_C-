/*Ejercicio I1: Intentemos hacer una calculadora basándonos en los conocimientos actuales
(Hasta el tema 2.1.9(Switch))*/
/*Iniciativa: He visto de pasada el while. Intentemos que la calculadora no cierre hasta que no hagamos una operación de 0(operador)0*/
using System;
/*public class EjercicioI1
{
	public static void Main()
	{
		int n1, n2, resultado;
		char operador;
		Console.Write("Introduce un número entero: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		operador = 'Z';
		resultado = 0;
		while (n1 != 0)
		{
			Console.WriteLine("Introduce el operador: ");
			Console.WriteLine("+ para sumar.");
			Console.WriteLine("- para restar.");
			Console.WriteLine("x para multiplicar.");
			Console.WriteLine("/ para dividir.");
			operador = Convert.ToChar(Console.ReadLine());
			Console.Write("Introduce el número entero a operar: ");
			n2 = Convert.ToInt32(Console.ReadLine());
			switch(operador)
			{
				case '+': resultado = n1 + n2;
			break;
				case '-': resultado = n1 - n2;
			break;
				case 'x': resultado = n1 * n2;
			break;
				case '/': resultado = n1 / n2;
			break;
				default: Console.WriteLine("No se qué hacer con eso que me das.");
			break;
			}
			if ((operador == '+') || (operador == '-') || (operador == 'x') || (operador == '/'))
				Console.WriteLine("{0} {1} {2} = {3}", n1, operador, n2, resultado);
			else Console.WriteLine("No sé qué hacer con eso que me das.");
			Console.WriteLine("Puedes introducir una nueva operación. 0 para salir.");
			Console.Write("Introduce un número entero: ");
			n1 = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("¡Hasta otra!");	
	}
}*/
public class EjercicioI1
{
	public static void Main()
	{
		double n1, n2 = 1.00, resultado = 0.00;
		char operador;
		Console.Write("Introduce un número: ");
		n1 = Convert.ToDouble(Console.ReadLine());
		do
		{
			Console.WriteLine("Introduce el operador: ");
			Console.WriteLine("+ para sumar.");
			Console.WriteLine("- para restar.");
			Console.WriteLine("x para multiplicar.");
			Console.WriteLine("/ para dividir.");
			Console.WriteLine("c para reiniciar la operación.");
			operador = Convert.ToChar(Console.ReadLine());
			if (operador != 'c')
			{
				Console.Write("Introduce otro número (0 para salir): ");
				n2 = Convert.ToDouble(Console.ReadLine());
			}
			switch(operador)
			{
				case '+': resultado = n1 + n2;
					break;
				case '-': resultado = n1 - n2;
					break;
				case 'x': resultado = n1 * n2;
					break;
				case '/': resultado = n1 / n2;
					break;
				case 'c': resultado = n1 * 0;
					break;
				default: Console.WriteLine("No se qué hacer con eso que me das.");
					break;
			}
			if ((operador == '+') || (operador == '-') || (operador == 'x') || (operador == '/'))
			{
				if (n2 != 0.0)
				{	
					Console.Clear();
					Console.WriteLine("{0} {1} {2} = {3}", n1, operador, n2, resultado);
					Console.WriteLine("¿Otra operación?");
					n1 = resultado;
				}
			}
			if (operador == 'c')
			{	
				Console.Clear();
				Console.WriteLine
				(
					"La operación se ha reiniciado a 0, introduce un nuevo número inicial: "
				);
				n1 = Convert.ToDouble(Console.ReadLine());
			}
		}
		while (n2 != 0.0);
		Console.WriteLine("¡Hasta otra!");
	}
}