/*Ejercicio 4.1.3.8: Un programa que reserve espacio para un vector de 3 componentes, pida
al usuario valores para dichas componentes (por ejemplo [2, -5, 7]) y muestre su
módulo (raíz cuadrada de la suma de sus componentes al cuadrado).*/
using System;
public class E4_1_3_8
{
    public static void Ejecutar()
    {
        double[] numeros = new double[3];
        double[] cuadrados = new double[3];
        double suma = 0, raiz;
        for (int i = 0; i <= 2; i++)
        {
            Console.Write("Introduce un número({0}): ", i + 1);
            numeros[i] = Convert.ToDouble(Console.ReadLine());
            cuadrados[i] = numeros[i] * numeros[i];
            suma += cuadrados[i];
        }
        raiz = Math.Sqrt(suma);
        Console.WriteLine("El módulo de los 3 números es {0}", raiz);
    }
}
