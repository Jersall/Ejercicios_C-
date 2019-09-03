/*Ejercicio 2.3.1: Crea un programa que escriba los numeros del 1 al 10, 
separados por un espacio, sin avanzar de linea.
Usa solo if y goto.*/
using System;
public class Ejercicio2_3_1
{
	public static void Ejecutar()
	{
		int i = 1;
		if (i == 1)
		{
			Console.Write("{0} ", i);
			i++;
			if (i == 2)
			{
				Console.Write("{0} ", i);
				i++;
				if (i == 3)
				{
					Console.Write("{0} ", i);
					i++;
					if (i == 4)
					{
						Console.Write("{0} ", i);
						i++;
						if (i == 5)
						{
							Console.Write("{0} ", i);
							i++;
							if (i == 6)
							{
								Console.Write("{0} ", i);
								i++;
								if (i == 7)
								{
									Console.Write("{0} ", i);
									i++;
									if (i == 8)
									{
										Console.Write("{0} ", i);
										i++;
										if (i == 9)
										{
											Console.Write("{0} ", i);
											i++;
											if (i == 10)
											{
												Console.WriteLine("{0}", i);
												goto findelcoñazoeste;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		findelcoñazoeste:
			Console.WriteLine("Fin del sufrimiento de escribir esto.");
	}
}
