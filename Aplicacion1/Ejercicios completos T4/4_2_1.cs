/*Ejercicio 4.2.1: Un programa que pida al usuario dos bloques de 10 números enteros
(usando un array de dos dimensiones). Después deberá mostrar el mayor dato
que se ha introducido en cada uno de ellos.*/

using System;

public class E4_2_1
{
    public static void Ejecutar()
    {
        int[,] nums = new int[2, 10];
        int maximog1 = -999999, maximog2 = -999999;
        for(int i = 0;i < 2;i++)
        {
            for (int j = 0;j < 10;j++)
            {
                Console.Write("Introduce un número para el grupo {0}(n{1}): ", i+1, j+1);
                nums[i, j] = Convert.ToInt32(Console.ReadLine());
                if((i == 0) && (j == 0))
                {
                    maximog1 = nums[i, j];
                }
                else
                if((i == 0) && (nums[i, j] > maximog1))
                {
                    maximog1 = nums[i, j];
                }
                if ((i == 1) && (j == 0))
                {
                    maximog2 = nums[i, j];
                }
                else
                if ((i == 1) && (nums[i, j] > maximog2))
                {
                    maximog2 = nums[i, j];
                }
            }
        }
        Console.Write("El máximo del grupo 1 es "+maximog1+". El máximo del grupo 2 es "+maximog2);
    }
}
