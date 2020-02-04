/*Ejercicio 4.4.7.2: Un programa que pida al usuario varios números separados por espacios
y muestre su suma.*/
using System;
public class E4_4_7_2
{
    public static void Ejecutar()
    {
        string numerosuelto;
        char separa = ' ';
        Console.Write("¿Numeros? dámelos con un espacio cada uno: ");
        numerosuelto = Convert.ToString((Console.ReadLine()));
        string[] factor = numerosuelto.Split(separa);
        int[] numerado = new int[factor.Length];
        int resultado = 0;
        for(int i = 0; i <= factor.Length - 1; i++)
        {
            Console.Write(factor[i] + " ");
            numerado[i] = Convert.ToInt32(factor[i]);
            resultado = resultado + numerado[i];
        }
        Console.WriteLine(resultado);
    }
}
