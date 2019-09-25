/*Ejercicio 4.1.3.10: Un programa que reserve espacio para dos vectores de 3 componentes,
pida al usuario sus valores y calcule su producto escalar (x1·y1+ x2·y2+x3·y3).*/
using System;
public class E4_1_3_10
{
    public static void Ejecutar()
    {
        int[] n1 = new int[3];
        int[] n2 = new int[3];
        int suma = 0;
        for(int i = 0; i <= 2; i++)
        {
            Console.Write("¿Numero {0}(n1)?: ", i + 1);
            n1[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Numero {0}(n2)?: ", i + 1);
            n2[i] = Convert.ToInt32(Console.ReadLine());
            suma += (n1[i] * n2[i]);
        }
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", n1[i], n2[i], n1[i] * n2[i]);
        }
        Console.WriteLine("Y su suma es {0}", suma);
    }
}

