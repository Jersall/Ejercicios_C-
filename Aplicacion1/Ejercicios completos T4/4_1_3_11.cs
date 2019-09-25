/*Ejercicio 4.1.3.10: Un programa que pida al usuario 4 números enteros y calcule (y
muestre) cuál es el mayor de ellos. Nota: para calcular el mayor valor de un array,
hay que comparar cada uno de los valores que tiene almacenados el array con el
que hasta ese momento es el máximo provisional. El valor inicial de este máximo
provisional no debería ser cero (porque el resultado sería incorrecto si todos los
números son negativos), sino el primer elemento del array.*/
using System;
public class E4_1_3_11
{
    public static void Ejecutar()
    {
        int[] num = new int[4];
        Console.Write("¿Numero 1?: ");
        num[0] = Convert.ToInt32(Console.ReadLine());
        int maximo = num[0];
        for (int i = 1; i <= 3; i++)
        {
            Console.Write("¿Numero {0}?: ", i+1);
            num[i] = Convert.ToInt32(Console.ReadLine());
            if (num[i] > maximo)
            {
                maximo = num[i];
            }
        }
        Console.WriteLine("El mayor numero entre los mencionados es {0}.", maximo);
    }
}
