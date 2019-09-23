/*Ejercicio 4.1.3.9: Un programa que reserve espacio para dos vectores de 3 componentes,
pida al usuario sus valores y calcule la suma de ambos vectores (su primera
componente será x1+y1, la segunda será x2+y2 y así sucesivamente).*/
using System;
public class E4_1_3_9
{
    public static void Ejecutar()
    {
        double[] n1 = new double[3];
        double[] n2 = new double[3];
        double suma;
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Introduce un número(n1)({0}): ", i + 1);
            n1[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce un número(n2)({0}): ", i + 1);
            n2[i] = Convert.ToDouble(Console.ReadLine());
            suma = n1[i] + n2[i];
            Console.WriteLine("la suma de la columna {0} es {1}", i + 1, suma);
        }
    }
}
