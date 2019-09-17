/*Ejercicio 4.1.3.3: Un programa que pida al usuario 10 reales de doble precisión, calcule su
media y luego muestre los que están por encima de la media.*/
using System;
public class E4_1_3_3
{
    public static void Ejecutar()
    {
        double[] dieznums = new double[10];
        double mednums, suma = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("¿Número {0}?: ", i + 1);
            dieznums[i] = Convert.ToDouble(Console.ReadLine());
            suma += dieznums[i];
        }
        mednums = suma / 10;
        Console.WriteLine("La media es {0}", mednums);
        for (int i = 0; i < 10; i++)
        {
            if (dieznums[i] > mednums)
            {
                Console.Write("({0}), ", dieznums[i]);
            }
        }
        Console.WriteLine("Están por encima de la media.");
    }
}

