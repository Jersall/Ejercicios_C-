/*Ejercicio 4.2.3: Un programa que pregunte al usuario el tamaño que tendrán dos bloques
de números enteros (por ejemplo, uno de 10 elementos y otro de 12). 
Luego pedirá los datos para ambos bloques de datos. 
Finalmente deberá mostrar el mayor dato que se ha introducido en cada uno de ellos.*/
using System;
public class E4_2_3
{
    public static void Ejecutar()
    {
        int[][] numerosrandom;
        int bloq1, bloq2, max1 = -999999, max2 = -999999;
        Console.Write("Introduce cuántos números irán en el Bloque 1: ");
        bloq1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce cuántos números irán en el Bloque 2: ");
        bloq2 = Convert.ToInt32(Console.ReadLine());
        numerosrandom = new int[2][];
        numerosrandom[0] = new int[bloq1];
        numerosrandom[1] = new int[bloq2];
        for(int j = 0; j < bloq1; j++)
        {
            Console.Write("¿Numero(B1, N{0})?: ", j+1);
            numerosrandom[0][j] = Convert.ToInt32(Console.ReadLine());
            if(numerosrandom[0][j] > max1)
            {
                max1 = numerosrandom[0][j];
            }
        }
        for (int i = 0; i < bloq2; i++)
        {
            Console.Write("¿Numero(B2, N{0})?: ", i + 1);
            numerosrandom[1][i] = Convert.ToInt32(Console.ReadLine());
            if (numerosrandom[1][i] > max2)
            {
                max2 = numerosrandom[1][i];
            }
        }
        Console.WriteLine("El máximo número del bloque 1 es " + max1);
        Console.WriteLine("El máximo numero del bloque 2 es " + max2);
    }
}
