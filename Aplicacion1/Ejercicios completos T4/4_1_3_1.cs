/*Ejercicio 4.1.3.1: Crea un programa que pida al usuario 6 números enteros cortos 
y luego los muestre en orden inverso (pista: usa un array para almacenarlos y 
"for" para mostrarlos).*/
using System;
public class E4_1_3_1
{
    public static void Ejecutar()
    {
        int[] nums = new int[6];
        Console.Write("¿Número 1?: ");
        nums[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Número 2?: ");
        nums[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Número 3?: ");
        nums[2] = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Número 4?: ");
        nums[3] = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Número 5?: ");
        nums[4] = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Número 6?: ");
        nums[5] = Convert.ToInt32(Console.ReadLine());
        for(int i = 5; i >= 1; i--)
        {
            Console.Write(nums[i] + ", ");
            if (i == 1)
            {
                i--;
                Console.WriteLine(nums[i]);
            }
        }

    }
}
