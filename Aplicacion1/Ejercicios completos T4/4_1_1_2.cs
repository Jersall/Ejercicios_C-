/*Ejercicio 4.1.1.2: Pide al usuario 5 numeros reales(float) 
 y que el programa muestre el orden contrario al que se introdujeron.*/
using System;
public class E4_1_1_2
{
    public static void Ejecutar()
    {
        float[] invertiresto = new float[5];
        Console.Write("¿Numero 1?: ");
        invertiresto[0] = Convert.ToSingle(Console.ReadLine());
        Console.Write("¿Numero 2?: ");
        invertiresto[1] = Convert.ToSingle(Console.ReadLine());
        Console.Write("¿Numero 3?: ");
        invertiresto[2] = Convert.ToSingle(Console.ReadLine());
        Console.Write("¿Numero 4?: ");
        invertiresto[3] = Convert.ToSingle(Console.ReadLine());
        Console.Write("¿Numero 5?: ");
        invertiresto[4] = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Al revés: {0}, {1}, {2}, {3}, {4}", invertiresto[4], invertiresto[3], invertiresto[2], invertiresto[1], invertiresto[0]);
    }
}
